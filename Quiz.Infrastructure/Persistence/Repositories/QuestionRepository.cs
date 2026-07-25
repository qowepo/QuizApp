using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Repositories;

/// <summary>
/// Реализация хранилища вопросов на базе Entity Framework Core.
/// </summary>
public sealed class QuestionRepository : IQuestionRepository
{
    private const int MaxBatchSize = 10;
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

        var candidates = await _dbContext.Questions
            .AsNoTracking()
            .Include(question => question.Options)
            .AsSplitQuery()
            .Where(question =>
                question.Topic == topic &&
                !_dbContext.UserAnswers.Any(answer =>
                    answer.UserId == userId &&
                    answer.QuestionId == question.Id))
            .ToListAsync(cancellationToken);

        var selected = new List<Question>(batchSize);
        var distribution = new (Difficulty Difficulty, int Count)[]
        {
            (Difficulty.Middle, 3),
            (Difficulty.MiddlePlus, 3),
            (Difficulty.Senior, 2),
            (Difficulty.SeniorPlus, 2)
        };

        foreach (var (difficulty, targetCount) in distribution)
        {
            selected.AddRange(candidates
                .Where(question =>
                    question.Difficulty == difficulty &&
                    !selected.Contains(question))
                .OrderBy(_ => Random.Shared.Next())
                .Take(Math.Min(targetCount, batchSize - selected.Count)));
        }

        if (selected.Count < batchSize)
        {
            selected.AddRange(candidates
                .Where(question => !selected.Contains(question))
                .OrderBy(_ => Random.Shared.Next())
                .Take(batchSize - selected.Count));
        }

        return selected
            .OrderBy(_ => Random.Shared.Next())
            .ToArray();
    }

    public Task<Question?> GetByIdAsync(
        Guid questionId,
        CancellationToken cancellationToken = default)
    {
        return _dbContext.Questions
            .Include(question => question.Answers)
            .Include(question => question.Options)
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

    public Task<int> DeleteAnswersByUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        if (userId == Guid.Empty)
        {
            throw new ArgumentException(
                "User identifier cannot be empty.",
                nameof(userId));
        }

        return _dbContext.UserAnswers
            .Where(answer => answer.UserId == userId)
            .ExecuteDeleteAsync(cancellationToken);
    }
}
