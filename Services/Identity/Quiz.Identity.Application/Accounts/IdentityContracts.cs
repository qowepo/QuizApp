namespace Quiz.Identity.Application.Accounts;

public sealed record RegisterUserRequest(
    string Email,
    string Password,
    string DisplayName);

public sealed record RegisterUserResult(
    bool Succeeded,
    Guid? UserId,
    IReadOnlyCollection<string> Errors)
{
    public static RegisterUserResult Success(Guid userId) =>
        new(true, userId, Array.Empty<string>());

    public static RegisterUserResult Failure(IEnumerable<string> errors) =>
        new(false, null, errors.ToArray());
}

public sealed record PasswordSignInRequest(
    string Email,
    string Password,
    bool RememberMe);

public enum PasswordSignInStatus
{
    Success,
    InvalidCredentials,
    LockedOut,
    NotAllowed,
    RequiresTwoFactor
}

/// <summary>
/// Безопасный снимок пользователя, который можно использовать при формировании claims.
/// </summary>
public sealed record IdentityUserSnapshot(
    Guid Id,
    string Email,
    string DisplayName,
    bool IsActive,
    IReadOnlyCollection<string> Roles);
