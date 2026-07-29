using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Quiz.Identity.Application.Accounts;
using Quiz.Identity.Application.Authorization;
using Quiz.Identity.Infrastructure.Persistence;

namespace Quiz.Identity.Infrastructure.Accounts;

public sealed class UserAccountService(
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager)
    : IUserAccountService
{
    public async Task<RegisterUserResult> RegisterAsync(
        RegisterUserRequest request,
        CancellationToken cancellationToken = default)
    {
        var normalizedEmail = request.Email.Trim();
        var existingUser = await userManager.FindByEmailAsync(normalizedEmail);

        if (existingUser is not null)
        {
            return RegisterUserResult.Failure(["A user with this email already exists."]);
        }

        var user = new ApplicationUser
        {
            Id = Guid.NewGuid(),
            UserName = normalizedEmail,
            Email = normalizedEmail,
            DisplayName = request.DisplayName.Trim(),
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            return RegisterUserResult.Failure(result.Errors.Select(error => error.Description));
        }

        var roleResult = await userManager.AddToRoleAsync(user, IdentityRoles.Student);
        if (!roleResult.Succeeded)
        {
            await userManager.DeleteAsync(user);
            return RegisterUserResult.Failure(roleResult.Errors.Select(error => error.Description));
        }

        return RegisterUserResult.Success(user.Id);
    }

    public async Task<PasswordSignInStatus> PasswordSignInAsync(
        PasswordSignInRequest request,
        CancellationToken cancellationToken = default)
    {
        var user = await userManager.FindByEmailAsync(request.Email.Trim());
        if (user is null || !user.IsActive)
        {
            return PasswordSignInStatus.InvalidCredentials;
        }

        var result = await signInManager.PasswordSignInAsync(
            user,
            request.Password,
            request.RememberMe,
            lockoutOnFailure: true);

        if (result.Succeeded)
        {
            return PasswordSignInStatus.Success;
        }

        if (result.IsLockedOut)
        {
            return PasswordSignInStatus.LockedOut;
        }

        if (result.IsNotAllowed)
        {
            return PasswordSignInStatus.NotAllowed;
        }

        if (result.RequiresTwoFactor)
        {
            return PasswordSignInStatus.RequiresTwoFactor;
        }

        return PasswordSignInStatus.InvalidCredentials;
    }

    public Task SignOutAsync() => signInManager.SignOutAsync();

    public async Task<IdentityUserSnapshot?> FindByIdAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        var user = await userManager.Users
            .AsNoTracking()
            .SingleOrDefaultAsync(candidate => candidate.Id == userId, cancellationToken);

        if (user is null)
        {
            return null;
        }

        var roles = await userManager.GetRolesAsync(user);

        return new IdentityUserSnapshot(
            user.Id,
            user.Email ?? string.Empty,
            user.DisplayName,
            user.IsActive,
            roles.ToArray());
    }
}
