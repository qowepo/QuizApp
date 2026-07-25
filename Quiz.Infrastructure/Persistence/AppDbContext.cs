using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence;

/// <summary>
/// Контекст базы данных приложения.
/// </summary>
public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions => Set<Question>();

    public DbSet<UserAnswer> UserAnswers => Set<UserAnswer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
