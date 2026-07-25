namespace Quiz.Application.Quiz.Queries.GetQuizBatch;

/// <summary>
/// Вопрос для прохождения квиза без эталонного ответа.
/// </summary>
public sealed record QuizQuestionDto(Guid Id, string Text);
