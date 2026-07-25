using MediatR;

namespace Quiz.Application.Quiz.Commands.ResetQuizProgress;

/// <summary>
/// Запрашивает удаление всей истории ответов текущего пользователя.
/// </summary>
public sealed record ResetQuizProgressCommand(string UserId) : IRequest<int>;
