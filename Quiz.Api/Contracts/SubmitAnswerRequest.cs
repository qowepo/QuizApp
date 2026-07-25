namespace Quiz.Api.Contracts;

/// <summary>
/// HTTP-модель отправки ответа пользователя.
/// </summary>
public sealed record SubmitAnswerRequest(
    Guid QuestionId,
    string AnswerText);
