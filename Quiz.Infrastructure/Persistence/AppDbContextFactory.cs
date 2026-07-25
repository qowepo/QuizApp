using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Quiz.Infrastructure.Persistence;

/// <summary>
/// Создаёт контекст для команд dotnet ef без запуска WebUI.
/// </summary>
public sealed class AppDbContextFactory
    : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlite("Data Source=quiz.db")
            .Options;

        return new AppDbContext(options);
    }
}
