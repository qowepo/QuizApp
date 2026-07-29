using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OpenIddict.Abstractions;
using Quiz.Identity.Application.Authorization;
using Quiz.Identity.Infrastructure.Persistence;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Quiz.Identity.Api.Setup;

public static class IdentityDatabaseInitializer
{
    public static async Task InitializeIdentityDatabaseAsync(
        this IServiceProvider services,
        IConfiguration configuration,
        IWebHostEnvironment environment,
        CancellationToken cancellationToken)
    {
        await using var scope = services.CreateAsyncScope();
        var serviceProvider = scope.ServiceProvider;
        var dbContext = serviceProvider.GetRequiredService<IdentityDbContext>();

        if (environment.IsDevelopment())
        {
            await dbContext.Database.MigrateAsync(cancellationToken);
        }

        await SeedRolesAsync(serviceProvider, cancellationToken);
        await SeedScopesAsync(serviceProvider, cancellationToken);
        await SeedClientsAsync(serviceProvider, configuration, cancellationToken);
    }

    private static async Task SeedRolesAsync(
        IServiceProvider services,
        CancellationToken cancellationToken)
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

        foreach (var roleName in IdentityRoles.All)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                var result = await roleManager.CreateAsync(
                    new IdentityRole<Guid>(roleName) { Id = Guid.NewGuid() });

                if (!result.Succeeded)
                {
                    throw new InvalidOperationException(
                        $"Cannot create role '{roleName}': " +
                        string.Join("; ", result.Errors.Select(error => error.Description)));
                }
            }
        }
    }

    private static async Task SeedScopesAsync(
        IServiceProvider services,
        CancellationToken cancellationToken)
    {
        var scopeManager = services.GetRequiredService<IOpenIddictScopeManager>();

        foreach (var scopeName in IdentityScopes.All)
        {
            if (await scopeManager.FindByNameAsync(scopeName, cancellationToken) is not null)
            {
                continue;
            }

            await scopeManager.CreateAsync(
                new OpenIddictScopeDescriptor
                {
                    Name = scopeName,
                    DisplayName = scopeName,
                    Resources = { IdentityResources.QuizApi }
                },
                cancellationToken);
        }
    }

    private static async Task SeedClientsAsync(
        IServiceProvider services,
        IConfiguration configuration,
        CancellationToken cancellationToken)
    {
        var applicationManager = services.GetRequiredService<IOpenIddictApplicationManager>();

        const string webClientId = "quiz-web-bff";
        if (await applicationManager.FindByClientIdAsync(webClientId, cancellationToken) is null)
        {
            var webClientSecret = configuration["IdentityClients:WebBff:ClientSecret"];
            if (string.IsNullOrWhiteSpace(webClientSecret))
            {
                throw new InvalidOperationException(
                    "IdentityClients:WebBff:ClientSecret must be supplied through user secrets or an environment variable.");
            }

            var redirectUri = configuration["IdentityClients:WebBff:RedirectUri"]
                ?? "https://localhost:7087/signin-oidc";
            var postLogoutRedirectUri = configuration["IdentityClients:WebBff:PostLogoutRedirectUri"]
                ?? "https://localhost:7087/";

            await applicationManager.CreateAsync(
                new OpenIddictApplicationDescriptor
                {
                    ClientId = webClientId,
                    ClientSecret = webClientSecret,
                    ClientType = ClientTypes.Confidential,
                    ConsentType = ConsentTypes.Implicit,
                    DisplayName = "Quiz Web BFF",
                    RedirectUris = { new Uri(redirectUri) },
                    PostLogoutRedirectUris = { new Uri(postLogoutRedirectUri) },
                    Permissions =
                    {
                        Permissions.Endpoints.Authorization,
                        Permissions.Endpoints.EndSession,
                        Permissions.Endpoints.Token,
                        Permissions.GrantTypes.AuthorizationCode,
                        Permissions.GrantTypes.RefreshToken,
                        Permissions.ResponseTypes.Code,
                        Permissions.Prefixes.Scope + Scopes.Email,
                        Permissions.Prefixes.Scope + Scopes.Profile,
                        Permissions.Prefixes.Scope + Scopes.Roles,
                        Permissions.Prefixes.Scope + IdentityScopes.QuizRead,
                        Permissions.Prefixes.Scope + IdentityScopes.QuizAnswer,
                        Permissions.Prefixes.Scope + IdentityScopes.ProgressRead,
                        Requirements.Features.ProofKeyForCodeExchange
                    }
                },
                cancellationToken);
        }

        const string serviceClientId = "quiz-service-client";
        if (await applicationManager.FindByClientIdAsync(serviceClientId, cancellationToken) is null)
        {
            var serviceClientSecret = configuration["IdentityClients:Service:ClientSecret"];
            if (string.IsNullOrWhiteSpace(serviceClientSecret))
            {
                throw new InvalidOperationException(
                    "IdentityClients:Service:ClientSecret must be supplied through user secrets or an environment variable.");
            }

            await applicationManager.CreateAsync(
                new OpenIddictApplicationDescriptor
                {
                    ClientId = serviceClientId,
                    ClientSecret = serviceClientSecret,
                    ClientType = ClientTypes.Confidential,
                    DisplayName = "Quiz internal services",
                    Permissions =
                    {
                        Permissions.Endpoints.Token,
                        Permissions.GrantTypes.ClientCredentials,
                        Permissions.Prefixes.Scope + IdentityScopes.QuizRead
                    }
                },
                cancellationToken);
        }
    }
}
