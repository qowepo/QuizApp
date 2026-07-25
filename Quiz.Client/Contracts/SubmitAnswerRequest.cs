namespace Quiz.Client.Contracts;

internal sealed record SubmitAnswerRequest(
    Guid QuestionId,
    string AnswerText);
