namespace Quiz.Application.Quiz.Commands.SubmitAnswer;

/// <summary>
/// Результат проверки выбранного варианта.
/// </summary>
public sealed record SubmitAnswerResult(
    bool IsCorrect,
    Guid SelectedOptionId,
    Guid CorrectOptionId,
    string DetailedExplanation,
    IReadOnlyList<AnswerOptionReviewDto> Options);

/// <summary>
/// Разбор одного варианта, который раскрывается после ответа.
/// </summary>
public sealed record AnswerOptionReviewDto(
    Guid Id,
    string Text,
    bool IsCorrect,
    string Explanation);
