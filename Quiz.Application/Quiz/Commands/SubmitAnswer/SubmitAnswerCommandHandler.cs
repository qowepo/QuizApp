using MediatR;
using Quiz.Domain.Questions;

namespace Quiz.Application.Quiz.Commands.SubmitAnswer;

/// <summary>
/// Сохраняет пользовательский ответ и возвращает эталонный ответ.
/// </summary>
public sealed class SubmitAnswerCommandHandler
    : IRequestHandler<SubmitAnswerCommand, SubmitAnswerResult>
{
    private readonly IQuestionRepository _questionRepository;

    public SubmitAnswerCommandHandler(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public async Task<SubmitAnswerResult> Handle(
        SubmitAnswerCommand request,
        CancellationToken cancellationToken)
    {
        if (!Guid.TryParse(request.UserId, out var userId))
        {
            throw new ArgumentException(
                "UserId must contain a valid GUID.",
                nameof(request.UserId));
        }

        var question = await _questionRepository.GetByIdAsync(
            request.QuestionId,
            cancellationToken);

        if (question is null)
        {
            throw new KeyNotFoundException(
                $"Question with identifier '{request.QuestionId}' was not found.");
        }

        var answer = question.AddAnswer(
            userId,
            request.AnswerOptionId,
            DateTimeOffset.UtcNow);

        await _questionRepository.SaveAnswerAsync(answer, cancellationToken);

        var correctOption = question.Options.Single(option => option.IsCorrect);

        return new SubmitAnswerResult(
            answer.IsCorrect == true,
            request.AnswerOptionId,
            correctOption.Id,
            question.IdealAnswer,
            question.Options
                .Select(option => new AnswerOptionReviewDto(
                    option.Id,
                    option.Text,
                    option.IsCorrect,
                    option.Explanation))
                .ToArray());
    }
}
