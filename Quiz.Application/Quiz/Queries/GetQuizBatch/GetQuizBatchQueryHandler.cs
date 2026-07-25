using MediatR;
using Quiz.Domain.Questions;

namespace Quiz.Application.Quiz.Queries.GetQuizBatch;

/// <summary>
/// Обрабатывает получение новой порции вопросов для пользователя.
/// </summary>
public sealed class GetQuizBatchQueryHandler
    : IRequestHandler<GetQuizBatchQuery, IReadOnlyList<QuizQuestionDto>>
{
    private const int BatchSize = 5;
    private readonly IQuestionRepository _questionRepository;

    public GetQuizBatchQueryHandler(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public async Task<IReadOnlyList<QuizQuestionDto>> Handle(
        GetQuizBatchQuery request,
        CancellationToken cancellationToken)
    {
        if (!Guid.TryParse(request.UserId, out var userId))
        {
            throw new ArgumentException(
                "UserId must contain a valid GUID.",
                nameof(request.UserId));
        }

        var questions = await _questionRepository.GetRandomUnansweredAsync(
            request.Topic,
            userId,
            BatchSize,
            cancellationToken);

        return questions
            .Select(question => new QuizQuestionDto(question.Id, question.Text))
            .ToArray();
    }
}
