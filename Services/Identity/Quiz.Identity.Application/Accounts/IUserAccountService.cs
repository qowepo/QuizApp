namespace Quiz.Identity.Application.Accounts;

/// <summary>
/// Описывает прикладные операции над учетной записью без зависимости от ASP.NET Core Identity.
/// </summary>
public interface IUserAccountService
{
    Task<RegisterUserResult> RegisterAsync(
        RegisterUserRequest request,
        CancellationToken cancellationToken = default);

    Task<PasswordSignInStatus> PasswordSignInAsync(
        PasswordSignInRequest request,
        CancellationToken cancellationToken = default);

    Task SignOutAsync();

    Task<IdentityUserSnapshot?> FindByIdAsync(
        Guid userId,
        CancellationToken cancellationToken = default);
}
