using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;

namespace Quiz.WebUI.Authentication;

public static class AuthenticationExtensions
{
    private const string RegistrationHintKey = "quiz-registration";

    public static IServiceCollection AddQuizAuthentication(
        this IServiceCollection services,
        IConfiguration configuration,
        IWebHostEnvironment environment)
    {
        var authority = configuration["Authentication:Authority"]
            ?? throw new InvalidOperationException(
                "Authentication:Authority is not configured.");
        var clientId = configuration["Authentication:ClientId"]
            ?? throw new InvalidOperationException(
                "Authentication:ClientId is not configured.");
        var clientSecret = configuration["Authentication:ClientSecret"];

        services
            .AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.Cookie.Name = "__Host-Quiz.WebUI";
                options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.Lax;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.ExpireTimeSpan = TimeSpan.FromHours(8);
                options.SlidingExpiration = true;
                options.LoginPath = "/auth/login";
                options.AccessDeniedPath = "/auth/access-denied";
            })
            .AddOpenIdConnect(options =>
            {
                options.Authority = authority;
                options.MetadataAddress =
                    $"{authority.TrimEnd('/')}/.well-known/openid-configuration";
                options.ClientId = clientId;
                options.ClientSecret = string.IsNullOrWhiteSpace(clientSecret)
                    ? null
                    : clientSecret;
                options.ResponseType = OpenIdConnectResponseType.Code;
                options.ResponseMode = OpenIdConnectResponseMode.FormPost;
                options.UsePkce = true;
                // Токены пока не кладём в browser cookie: quiz use cases выполняются
                // внутри WebUI. Для будущего HTTP API добавим server-side token store.
                options.SaveTokens = false;
                options.GetClaimsFromUserInfoEndpoint = true;
                options.MapInboundClaims = false;
                options.RequireHttpsMetadata = !environment.IsDevelopment();
                options.SignedOutCallbackPath = "/signout-callback-oidc";

                if (environment.IsDevelopment())
                {
                    options.BackchannelHttpHandler = new HttpClientHandler
                    {
                        // Только локальная разработка: Kestrel использует dev-certificate.
                        ServerCertificateCustomValidationCallback =
                            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                    };
                }

                options.Scope.Clear();
                options.Scope.Add("openid");
                options.Scope.Add("profile");
                options.Scope.Add("email");
                options.Scope.Add("roles");
                options.Scope.Add("quiz.read");
                options.Scope.Add("quiz.answer");
                options.Scope.Add("progress.read");

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = "name",
                    RoleClaimType = "role"
                };

                options.Events.OnRedirectToIdentityProvider = context =>
                {
                    if (context.Properties.Items.ContainsKey(RegistrationHintKey))
                    {
                        context.ProtocolMessage.SetParameter("screen_hint", "signup");
                    }

                    return Task.CompletedTask;
                };

                options.Events.OnTokenValidated = context =>
                {
                    var subject = context.Principal?.FindFirst("sub")?.Value;
                    if (!Guid.TryParse(subject, out _))
                    {
                        context.Fail("The identity token does not contain a valid subject.");
                    }

                    return Task.CompletedTask;
                };
            });

        services.AddAuthorization();
        services.AddCascadingAuthenticationState();

        return services;
    }

    public static IEndpointRouteBuilder MapQuizAuthenticationEndpoints(
        this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet(
                "/auth/login",
                (string? returnUrl) => Results.Challenge(
                    CreateAuthenticationProperties(returnUrl),
                    [OpenIdConnectDefaults.AuthenticationScheme]))
            .AllowAnonymous();

        endpoints.MapGet(
                "/auth/register",
                (string? returnUrl) =>
                {
                    var properties = CreateAuthenticationProperties(returnUrl);
                    properties.Items[RegistrationHintKey] = bool.TrueString;

                    return Results.Challenge(
                        properties,
                        [OpenIdConnectDefaults.AuthenticationScheme]);
                })
            .AllowAnonymous();

        endpoints.MapPost(
                "/auth/logout",
                () => Results.SignOut(
                    new AuthenticationProperties { RedirectUri = "/" },
                    [
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        OpenIdConnectDefaults.AuthenticationScheme
                    ]))
            .RequireAuthorization();

        endpoints.MapGet(
            "/auth/access-denied",
            () => Results.Text(
                "Access denied.",
                statusCode: StatusCodes.Status403Forbidden));

        return endpoints;
    }

    private static AuthenticationProperties CreateAuthenticationProperties(
        string? returnUrl)
    {
        var safeReturnUrl =
            !string.IsNullOrWhiteSpace(returnUrl) &&
            Uri.IsWellFormedUriString(returnUrl, UriKind.Relative) &&
            returnUrl.StartsWith('/') &&
            !returnUrl.StartsWith("//")
                ? returnUrl
                : "/";

        return new AuthenticationProperties { RedirectUri = safeReturnUrl };
    }
}
