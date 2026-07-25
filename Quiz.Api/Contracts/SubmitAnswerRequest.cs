namespace Quiz.Api.Contracts;

/// <summary>
/// HTTP-модель отправки ответа пользователя.
/// </summary>
public sealed record SubmitAnswerRequest(
    string UserId,
    Guid QuestionId,
    string AnswerText);
