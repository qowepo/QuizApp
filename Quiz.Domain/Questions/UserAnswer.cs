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
        Guid answerOptionId,
        string answerText,
        bool isCorrect,
        DateTimeOffset createdAt)
        : base(id)
    {
        UserId = userId;
        QuestionId = questionId;
        AnswerOptionId = answerOptionId;
        AnswerText = answerText;
        IsCorrect = isCorrect;
        CreatedAt = createdAt;
    }

    private UserAnswer()
        : base(Guid.Empty)
    {
    }

    public Guid UserId { get; private set; }

    public Guid QuestionId { get; private set; }

    public Guid? AnswerOptionId { get; private set; }

    public string AnswerText { get; private set; } = string.Empty;

    public bool? IsCorrect { get; private set; }

    public DateTimeOffset CreatedAt { get; private set; }

    /// <summary>
    /// Создаёт новый ответ и проверяет обязательные данные.
    /// Доступен только внутри доменного слоя и вызывается агрегатом Question.
    /// </summary>
    internal static UserAnswer Create(
        Guid userId,
        Guid questionId,
        AnswerOption answerOption,
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

        if (answerOption.QuestionId != questionId)
        {
            throw new ArgumentException(
                "Answer option does not belong to the question.",
                nameof(answerOption));
        }

        return new UserAnswer(
            Guid.NewGuid(),
            userId,
            questionId,
            answerOption.Id,
            answerOption.Text,
            answerOption.IsCorrect,
            createdAt);
    }
}
