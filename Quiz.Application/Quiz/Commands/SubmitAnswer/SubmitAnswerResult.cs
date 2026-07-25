namespace Quiz.Application.Quiz.Commands.SubmitAnswer;

/// <summary>
/// Результат сохранения ответа, доступный для самопроверки пользователя.
/// </summary>
public sealed record SubmitAnswerResult(string IdealAnswer);
