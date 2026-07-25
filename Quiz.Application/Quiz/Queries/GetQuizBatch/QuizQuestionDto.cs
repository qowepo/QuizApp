using Quiz.Domain.Questions;

namespace Quiz.Application.Quiz.Queries.GetQuizBatch;

/// <summary>
/// Вопрос для прохождения квиза без признака правильного варианта.
/// </summary>
public sealed record QuizQuestionDto(
    Guid Id,
    string Text,
    Difficulty Difficulty,
    IReadOnlyList<QuizAnswerOptionDto> Options);

/// <summary>
/// Безопасный вариант ответа без результата и объяснения.
/// </summary>
public sealed record QuizAnswerOptionDto(Guid Id, string Text);
