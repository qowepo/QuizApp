using MediatR;

namespace Quiz.Application.Quiz.Commands.SubmitAnswer;

/// <summary>
/// Команда отправки ответа пользователя на вопрос.
/// </summary>
public sealed record SubmitAnswerCommand(
    string UserId,
    Guid QuestionId,
    string AnswerText) : IRequest<SubmitAnswerResult>;
