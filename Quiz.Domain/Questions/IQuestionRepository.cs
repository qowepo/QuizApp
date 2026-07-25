namespace Quiz.Domain.Questions;

/// <summary>
/// Контракт хранилища вопросов и пользовательских ответов.
/// </summary>
public interface IQuestionRepository
{
    /// <summary>
    /// Возвращает случайные вопросы, на которые пользователь ещё не отвечал.
    /// </summary>
    Task<IReadOnlyList<Question>> GetRandomUnansweredAsync(
        Topic topic,
        Guid userId,
        int count,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Находит вопрос по идентификатору.
    /// </summary>
    Task<Question?> GetByIdAsync(
        Guid questionId,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Сохраняет созданный пользователем ответ.
    /// </summary>
    Task SaveAnswerAsync(
        UserAnswer answer,
        CancellationToken cancellationToken = default);
}
