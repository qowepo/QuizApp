using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Quiz.Identity.Application.Accounts;

namespace Quiz.Identity.Api.Controllers;

[Route("account")]
public sealed class AccountController(
    IUserAccountService accountService) : Controller
{
    [HttpGet("login")]
    public IActionResult Login([FromQuery] string? returnUrl = null) =>
        View(new LoginViewModel { ReturnUrl = returnUrl });

    [HttpPost("login")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(
        LoginViewModel model,
        CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var status = await accountService.PasswordSignInAsync(
            new PasswordSignInRequest(model.Email, model.Password, model.RememberMe),
            cancellationToken);

        if (status == PasswordSignInStatus.Success)
        {
            return LocalRedirect(GetSafeReturnUrl(model.ReturnUrl));
        }

        ModelState.AddModelError(
            string.Empty,
            status == PasswordSignInStatus.LockedOut
                ? "The account is temporarily locked. Try again later."
                : "Invalid email or password.");

        return View(model);
    }

    [HttpGet("register")]
    public IActionResult Register([FromQuery] string? returnUrl = null) =>
        View(new RegisterViewModel { ReturnUrl = returnUrl });

    [HttpPost("register")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(
        RegisterViewModel model,
        CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var result = await accountService.RegisterAsync(
            new RegisterUserRequest(model.Email, model.Password, model.DisplayName),
            cancellationToken);

        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error);
            }

            return View(model);
        }

        var signInStatus = await accountService.PasswordSignInAsync(
            new PasswordSignInRequest(model.Email, model.Password, RememberMe: false),
            cancellationToken);

        if (signInStatus != PasswordSignInStatus.Success)
        {
            return RedirectToAction(nameof(Login), new { model.ReturnUrl });
        }

        return LocalRedirect(GetSafeReturnUrl(model.ReturnUrl));
    }

    [HttpGet("access-denied")]
    public IActionResult AccessDenied() => View();

    private string GetSafeReturnUrl(string? returnUrl) =>
        !string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl)
            ? returnUrl
            : "/";
}

public sealed class LoginViewModel
{
    [Required, EmailAddress]
    public string Email { get; init; } = string.Empty;

    [Required, DataType(DataType.Password)]
    public string Password { get; init; } = string.Empty;

    public bool RememberMe { get; init; }

    public string? ReturnUrl { get; init; }
}

public sealed class RegisterViewModel
{
    [Required, StringLength(160, MinimumLength = 2)]
    public string DisplayName { get; init; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; init; } = string.Empty;

    [Required, DataType(DataType.Password), MinLength(10)]
    public string Password { get; init; } = string.Empty;

    public string? ReturnUrl { get; init; }
}
