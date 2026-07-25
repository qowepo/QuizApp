using Quiz.Domain.Common;

namespace Quiz.Domain.Questions;

/// <summary>
/// Вариант ответа, принадлежащий конкретному вопросу.
/// </summary>
public sealed class AnswerOption : Entity<Guid>
{
    private AnswerOption(
        Guid id,
        Guid questionId,
        string text,
        bool isCorrect,
        string explanation)
        : base(id)
    {
        QuestionId = questionId;
        Text = text;
        IsCorrect = isCorrect;
        Explanation = explanation;
    }

    private AnswerOption()
        : base(Guid.Empty)
    {
    }

    public Guid QuestionId { get; private set; }

    public string Text { get; private set; } = string.Empty;

    public bool IsCorrect { get; private set; }

    public string Explanation { get; private set; } = string.Empty;

    internal static AnswerOption Create(
        Guid questionId,
        string text,
        bool isCorrect,
        string explanation)
    {
        if (questionId == Guid.Empty)
        {
            throw new ArgumentException(
                "Question identifier cannot be empty.",
                nameof(questionId));
        }

        if (string.IsNullOrWhiteSpace(text))
        {
            throw new ArgumentException(
                "Answer option text cannot be empty.",
                nameof(text));
        }

        if (string.IsNullOrWhiteSpace(explanation))
        {
            throw new ArgumentException(
                "Answer option explanation cannot be empty.",
                nameof(explanation));
        }

        return new AnswerOption(
            Guid.NewGuid(),
            questionId,
            text.Trim(),
            isCorrect,
            explanation.Trim());
    }
}
