using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Repositories;

/// <summary>
/// Реализация хранилища вопросов на базе Entity Framework Core.
/// </summary>
public sealed class QuestionRepository : IQuestionRepository
{
    private const int MaxBatchSize = 5;
    private readonly AppDbContext _dbContext;

    public QuestionRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IReadOnlyList<Question>> GetRandomUnansweredAsync(
        Topic topic,
        Guid userId,
        int count,
        CancellationToken cancellationToken = default)
    {
        if (userId == Guid.Empty)
        {
            throw new ArgumentException(
                "User identifier cannot be empty.",
                nameof(userId));
        }

        if (count <= 0)
        {
            return [];
        }

        var batchSize = Math.Min(count, MaxBatchSize);

        return await _dbContext.Questions
            .AsNoTracking()
            .Where(question =>
                question.Topic == topic &&
                !_dbContext.UserAnswers.Any(answer =>
                    answer.UserId == userId &&
                    answer.QuestionId == question.Id))
            .OrderBy(_ => EF.Functions.Random())
            .Take(batchSize)
            .ToListAsync(cancellationToken);
    }

    public Task<Question?> GetByIdAsync(
        Guid questionId,
        CancellationToken cancellationToken = default)
    {
        return _dbContext.Questions
            .Include(question => question.Answers)
            .SingleOrDefaultAsync(
                question => question.Id == questionId,
                cancellationToken);
    }

    public async Task SaveAnswerAsync(
        UserAnswer answer,
        CancellationToken cancellationToken = default)
    {
        await _dbContext.UserAnswers.AddAsync(answer, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
