using Quiz.Domain.Common;

namespace Quiz.Domain.Questions;

/// <summary>
/// Ответ пользователя на конкретный вопрос.
/// </summary>
public sealed class UserAnswer : Entity<Guid>
{
    private UserAnswer(
        Guid id,
        Guid userId,
        Guid questionId,
        string answerText,
        DateTimeOffset createdAt)
        : base(id)
    {
        UserId = userId;
        QuestionId = questionId;
        AnswerText = answerText;
        CreatedAt = createdAt;
    }

    private UserAnswer()
        : base(Guid.Empty)
    {
    }

    public Guid UserId { get; private set; }

    public Guid QuestionId { get; private set; }

    public string AnswerText { get; private set; } = string.Empty;

    public DateTimeOffset CreatedAt { get; private set; }

    /// <summary>
    /// Создаёт новый ответ и проверяет обязательные данные.
    /// Доступен только внутри доменного слоя и вызывается агрегатом Question.
    /// </summary>
    internal static UserAnswer Create(
        Guid userId,
        Guid questionId,
        string answerText,
        DateTimeOffset createdAt)
    {
        if (userId == Guid.Empty)
        {
            throw new ArgumentException("User identifier cannot be empty.", nameof(userId));
        }

        if (questionId == Guid.Empty)
        {
            throw new ArgumentException("Question identifier cannot be empty.", nameof(questionId));
        }

        if (string.IsNullOrWhiteSpace(answerText))
        {
            throw new ArgumentException("Answer text cannot be empty.", nameof(answerText));
        }

        return new UserAnswer(
            Guid.NewGuid(),
            userId,
            questionId,
            answerText.Trim(),
            createdAt);
    }
}
