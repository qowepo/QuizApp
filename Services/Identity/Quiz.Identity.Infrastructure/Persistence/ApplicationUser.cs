using Microsoft.AspNetCore.Identity;

namespace Quiz.Identity.Infrastructure.Persistence;

/// <summary>
/// Учетная запись пользователя. Пароли и защитные токены обслуживает ASP.NET Core Identity.
/// </summary>
public sealed class ApplicationUser : IdentityUser<Guid>
{
    public string DisplayName { get; set; } = string.Empty;

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    public bool IsActive { get; set; } = true;
}
