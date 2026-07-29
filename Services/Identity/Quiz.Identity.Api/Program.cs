using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Quiz.Identity.Application.Accounts;
using Quiz.Identity.Infrastructure.Accounts;
using Quiz.Identity.Infrastructure.Persistence;
using Quiz.Identity.Api.Setup;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("IdentityDatabase")
    ?? throw new InvalidOperationException(
        "Connection string 'IdentityDatabase' is not configured.");

builder.Services.AddDbContext<IdentityDbContext>(options =>
{
    options.UseNpgsql(connectionString);
    options.UseOpenIddict();
});

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
    {
        options.User.RequireUniqueEmail = true;
        options.SignIn.RequireConfirmedEmail = false;

        options.Password.RequiredLength = 10;
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = true;

        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    })
    .AddEntityFrameworkStores<IdentityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "__Host-Quiz.Identity";
    options.Cookie.HttpOnly = true;
    options.Cookie.SameSite = SameSiteMode.Lax;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/access-denied";
    options.ExpireTimeSpan = TimeSpan.FromHours(8);
    options.SlidingExpiration = true;
});

builder.Services.AddScoped<IUserAccountService, UserAccountService>();

builder.Services
    .AddOpenIddict()
    .AddCore(options =>
    {
        options.UseEntityFrameworkCore()
            .UseDbContext<IdentityDbContext>();
    })
    .AddServer(options =>
    {
        options.SetAuthorizationEndpointUris("/connect/authorize")
            .SetTokenEndpointUris("/connect/token")
            .SetEndSessionEndpointUris("/connect/logout")
            .SetUserInfoEndpointUris("/connect/userinfo");

        options.AllowAuthorizationCodeFlow()
            .RequireProofKeyForCodeExchange();
        options.AllowRefreshTokenFlow();
        options.AllowClientCredentialsFlow();

        options.SetAccessTokenLifetime(TimeSpan.FromMinutes(15));
        options.SetRefreshTokenLifetime(TimeSpan.FromDays(14));

        options.AddDevelopmentEncryptionCertificate()
            .AddDevelopmentSigningCertificate();

        // Подписанный JWT удобен для независимой валидации в ресурсных микросервисах.
        options.DisableAccessTokenEncryption();

        options.UseAspNetCore()
            .EnableAuthorizationEndpointPassthrough()
            .EnableTokenEndpointPassthrough()
            .EnableEndSessionEndpointPassthrough()
            .EnableUserInfoEndpointPassthrough();
    })
    .AddValidation(options =>
    {
        options.UseLocalServer();
        options.UseAspNetCore();
    });

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddHealthChecks()
    .AddDbContextCheck<IdentityDbContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();
app.MapHealthChecks("/health");
app.MapGet("/", () => Results.Redirect("/account/login"));

await app.Services.InitializeIdentityDatabaseAsync(
    app.Configuration,
    app.Environment,
    app.Lifetime.ApplicationStopping);

await app.RunAsync();

public partial class Program;
