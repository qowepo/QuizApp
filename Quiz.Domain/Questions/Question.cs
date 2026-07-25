using Quiz.Domain.Common;

namespace Quiz.Domain.Questions;

/// <summary>
/// Корень агрегата вопроса, управляющий связанными ответами пользователей.
/// </summary>
public sealed class Question : Entity<Guid>
{
    // Изменение коллекции разрешено только методам агрегата.
    private readonly List<UserAnswer> _answers = [];

    private Question(
        Guid id,
        Topic topic,
        string text,
        string idealAnswer)
        : base(id)
    {
        Topic = topic;
        Text = text;
        IdealAnswer = idealAnswer;
    }

    private Question()
        : base(Guid.Empty)
    {
    }

    public Topic Topic { get; private set; }

    public string Text { get; private set; } = string.Empty;

    public string IdealAnswer { get; private set; } = string.Empty;

    public IReadOnlyCollection<UserAnswer> Answers => _answers.AsReadOnly();

    /// <summary>
    /// Создаёт новый вопрос после проверки его обязательных полей.
    /// </summary>
    public static Question Create(
        Topic topic,
        string text,
        string idealAnswer)
    {
        if (!Enum.IsDefined(topic))
        {
            throw new ArgumentOutOfRangeException(nameof(topic), topic, "Unknown topic.");
        }

        if (string.IsNullOrWhiteSpace(text))
        {
            throw new ArgumentException("Question text cannot be empty.", nameof(text));
        }

        if (string.IsNullOrWhiteSpace(idealAnswer))
        {
            throw new ArgumentException("Ideal answer cannot be empty.", nameof(idealAnswer));
        }

        return new Question(
            Guid.NewGuid(),
            topic,
            text.Trim(),
            idealAnswer.Trim());
    }

    /// <summary>
    /// Добавляет ответ пользователя и запрещает повторный ответ на тот же вопрос.
    /// </summary>
    public UserAnswer AddAnswer(
        Guid userId,
        string answerText,
        DateTimeOffset createdAt)
    {
        if (_answers.Any(answer => answer.UserId == userId))
        {
            throw new InvalidOperationException(
                "The user has already answered this question.");
        }

        var answer = UserAnswer.Create(userId, Id, answerText, createdAt);
        _answers.Add(answer);

        return answer;
    }
}
