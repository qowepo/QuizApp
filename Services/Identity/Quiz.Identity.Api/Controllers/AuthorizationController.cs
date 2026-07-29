using System.Security.Claims;
using System.Collections.Immutable;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OpenIddict.Abstractions;
using OpenIddict.Server.AspNetCore;
using OpenIddict.Validation.AspNetCore;
using Quiz.Identity.Application.Accounts;
using Quiz.Identity.Application.Authorization;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Quiz.Identity.Api.Controllers;

public sealed class AuthorizationController(
    IUserAccountService accountService) : Controller
{
    [HttpGet("~/connect/authorize")]
    [HttpPost("~/connect/authorize")]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> Authorize(CancellationToken cancellationToken)
    {
        var request = HttpContext.GetOpenIddictServerRequest()
            ?? throw new InvalidOperationException("The OpenID Connect request is unavailable.");

        var authentication = await HttpContext.AuthenticateAsync(
            IdentityConstants.ApplicationScheme);

        if (!authentication.Succeeded)
        {
            return Challenge(
                new AuthenticationProperties
                {
                    RedirectUri = $"{Request.PathBase}{Request.Path}{Request.QueryString}"
                },
                IdentityConstants.ApplicationScheme);
        }

        var userIdValue = authentication.Principal?.FindFirstValue(ClaimTypes.NameIdentifier);
        if (!Guid.TryParse(userIdValue, out var userId))
        {
            await accountService.SignOutAsync();
            return Challenge(IdentityConstants.ApplicationScheme);
        }

        var user = await accountService.FindByIdAsync(userId, cancellationToken);
        if (user is null || !user.IsActive)
        {
            await accountService.SignOutAsync();
            return Challenge(IdentityConstants.ApplicationScheme);
        }

        var principal = CreateUserPrincipal(user, request.GetScopes());
        return SignIn(
            principal,
            OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
    }

    [HttpPost("~/connect/token")]
    [Produces("application/json")]
    public async Task<IActionResult> Exchange(CancellationToken cancellationToken)
    {
        var request = HttpContext.GetOpenIddictServerRequest()
            ?? throw new InvalidOperationException("The OpenID Connect request is unavailable.");

        if (request.IsClientCredentialsGrantType())
        {
            var identity = new ClaimsIdentity(
                TokenValidationParameters.DefaultAuthenticationType,
                Claims.Name,
                Claims.Role);

            identity.SetClaim(Claims.Subject, request.ClientId!);
            identity.SetClaim(Claims.Name, request.ClientId!);

            var servicePrincipal = new ClaimsPrincipal(identity);
            servicePrincipal.SetScopes(request.GetScopes());
            servicePrincipal.SetResources(IdentityResources.QuizApi);
            SetClaimDestinations(servicePrincipal);

            return SignIn(
                servicePrincipal,
                OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
        }

        if (request.IsAuthorizationCodeGrantType() || request.IsRefreshTokenGrantType())
        {
            var authentication = await HttpContext.AuthenticateAsync(
                OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);

            var subject = authentication.Principal?.GetClaim(Claims.Subject);
            if (!Guid.TryParse(subject, out var userId))
            {
                return Forbid(OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
            }

            var user = await accountService.FindByIdAsync(userId, cancellationToken);
            if (user is null || !user.IsActive)
            {
                return Forbid(OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
            }

            var principal = CreateUserPrincipal(
                user,
                authentication.Principal!.GetScopes());

            return SignIn(
                principal,
                OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
        }

        throw new InvalidOperationException("The specified grant type is not supported.");
    }

    [Authorize(AuthenticationSchemes =
        OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme)]
    [HttpGet("~/connect/userinfo")]
    [HttpPost("~/connect/userinfo")]
    [Produces("application/json")]
    public IActionResult UserInfo()
    {
        var response = new Dictionary<string, object?>
        {
            [Claims.Subject] = User.GetClaim(Claims.Subject),
            [Claims.Name] = User.GetClaim(Claims.Name)
        };

        if (User.HasScope(Scopes.Email))
        {
            response[Claims.Email] = User.GetClaim(Claims.Email);
        }

        if (User.HasScope(Scopes.Roles))
        {
            response[Claims.Role] = User.GetClaims(Claims.Role).ToArray();
        }

        return Ok(response);
    }

    [Authorize]
    [HttpGet("~/connect/logout")]
    [HttpPost("~/connect/logout")]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> Logout()
    {
        await accountService.SignOutAsync();

        return SignOut(
            new AuthenticationProperties { RedirectUri = "/" },
            OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
    }

    private static ClaimsPrincipal CreateUserPrincipal(
        IdentityUserSnapshot user,
        IEnumerable<string> scopes)
    {
        var identity = new ClaimsIdentity(
            TokenValidationParameters.DefaultAuthenticationType,
            Claims.Name,
            Claims.Role);

        identity.SetClaim(Claims.Subject, user.Id.ToString());
        identity.SetClaim(Claims.Email, user.Email);
        identity.SetClaim(Claims.Name, user.DisplayName);
        identity.SetClaims(Claims.Role, user.Roles.ToImmutableArray());

        var principal = new ClaimsPrincipal(identity);
        principal.SetScopes(scopes);
        principal.SetResources(IdentityResources.QuizApi);
        SetClaimDestinations(principal);

        return principal;
    }

    private static void SetClaimDestinations(ClaimsPrincipal principal)
    {
        principal.SetDestinations(claim => claim.Type switch
        {
            Claims.Name when claim.Subject!.HasScope(Scopes.Profile) =>
                [Destinations.AccessToken, Destinations.IdentityToken],
            Claims.Email when claim.Subject!.HasScope(Scopes.Email) =>
                [Destinations.AccessToken, Destinations.IdentityToken],
            Claims.Role when claim.Subject!.HasScope(Scopes.Roles) =>
                [Destinations.AccessToken, Destinations.IdentityToken],
            Claims.Subject =>
                [Destinations.AccessToken, Destinations.IdentityToken],
            _ => [Destinations.AccessToken]
        });
    }
}
