using Quiz.Domain.Common;

namespace Quiz.Domain.Questions;

/// <summary>
/// Корень агрегата вопроса, управляющий связанными ответами пользователей.
/// </summary>
public sealed class Question : Entity<Guid>
{
    // Изменение коллекции разрешено только методам агрегата.
    private readonly List<UserAnswer> _answers = [];
    private readonly List<AnswerOption> _options = [];

    private Question(
        Guid id,
        Topic topic,
        Difficulty difficulty,
        string text,
        string idealAnswer)
        : base(id)
    {
        Topic = topic;
        Difficulty = difficulty;
        Text = text;
        IdealAnswer = idealAnswer;
    }

    private Question()
        : base(Guid.Empty)
    {
    }

    public Topic Topic { get; private set; }

    public Difficulty Difficulty { get; private set; }

    public string Text { get; private set; } = string.Empty;

    public string IdealAnswer { get; private set; } = string.Empty;

    public IReadOnlyCollection<UserAnswer> Answers => _answers.AsReadOnly();

    public IReadOnlyCollection<AnswerOption> Options => _options.AsReadOnly();

    /// <summary>
    /// Создаёт новый вопрос после проверки его обязательных полей.
    /// </summary>
    public static Question Create(
        Topic topic,
        Difficulty difficulty,
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

        if (!Enum.IsDefined(difficulty))
        {
            throw new ArgumentOutOfRangeException(
                nameof(difficulty),
                difficulty,
                "Unknown difficulty.");
        }

        return new Question(
            Guid.NewGuid(),
            topic,
            difficulty,
            text.Trim(),
            idealAnswer.Trim());
    }

    /// <summary>
    /// Добавляет один из четырёх вариантов и не допускает двух правильных ответов.
    /// </summary>
    public AnswerOption AddOption(
        string text,
        bool isCorrect,
        string explanation)
    {
        if (_options.Count >= 4)
        {
            throw new InvalidOperationException(
                "A question cannot contain more than four answer options.");
        }

        if (isCorrect && _options.Any(option => option.IsCorrect))
        {
            throw new InvalidOperationException(
                "A question can contain only one correct answer option.");
        }

        var option = AnswerOption.Create(
            Id,
            text,
            isCorrect,
            explanation);

        _options.Add(option);

        return option;
    }

    /// <summary>
    /// Добавляет ответ пользователя и запрещает повторный ответ на тот же вопрос.
    /// </summary>
    public UserAnswer AddAnswer(
        Guid userId,
        Guid answerOptionId,
        DateTimeOffset createdAt)
    {
        if (_answers.Any(answer => answer.UserId == userId))
        {
            throw new InvalidOperationException(
                "The user has already answered this question.");
        }

        if (_options.Count != 4 ||
            _options.Count(option => option.IsCorrect) != 1)
        {
            throw new InvalidOperationException(
                "The question must contain four options and exactly one correct answer.");
        }

        var selectedOption = _options.SingleOrDefault(
            option => option.Id == answerOptionId);

        if (selectedOption is null)
        {
            throw new ArgumentException(
                "The selected answer option does not belong to this question.",
                nameof(answerOptionId));
        }

        var answer = UserAnswer.Create(
            userId,
            Id,
            selectedOption,
            createdAt);

        _answers.Add(answer);

        return answer;
    }
}
