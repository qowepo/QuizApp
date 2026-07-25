using MediatR;
using Quiz.Domain.Questions;

namespace Quiz.Application.Quiz.Commands.ResetQuizProgress;

/// <summary>
/// Сбрасывает прогресс пользователя и возвращает число удалённых ответов.
/// </summary>
public sealed class ResetQuizProgressCommandHandler
    : IRequestHandler<ResetQuizProgressCommand, int>
{
    private readonly IQuestionRepository _questionRepository;

    public ResetQuizProgressCommandHandler(
        IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public Task<int> Handle(
        ResetQuizProgressCommand request,
        CancellationToken cancellationToken)
    {
        if (!Guid.TryParse(request.UserId, out var userId))
        {
            throw new ArgumentException(
                "UserId must contain a valid GUID.",
                nameof(request.UserId));
        }

        return _questionRepository.DeleteAnswersByUserAsync(
            userId,
            cancellationToken);
    }
}
