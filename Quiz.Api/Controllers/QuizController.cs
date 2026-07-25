using MediatR;
using Microsoft.AspNetCore.Mvc;
using Quiz.Api.Contracts;
using Quiz.Application.Quiz.Commands.SubmitAnswer;
using Quiz.Application.Quiz.Queries.GetQuizBatch;
using Quiz.Domain.Questions;

namespace Quiz.Api.Controllers;

/// <summary>
/// Предоставляет операции запуска квиза и отправки ответа.
/// </summary>
[ApiController]
[Route("api/quiz")]
public sealed class QuizController : ControllerBase
{
    private const string UserIdHeaderName = "X-User-Id";
    private readonly IMediator _mediator;

    public QuizController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Возвращает до пяти вопросов выбранной темы без эталонных ответов.
    /// </summary>
    [HttpGet("{topic}/start")]
    [ProducesResponseType<IReadOnlyList<QuizQuestionDto>>(StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<QuizQuestionDto>>> Start(
        [FromRoute] Topic topic,
        [FromHeader(Name = UserIdHeaderName)] string userId,
        CancellationToken cancellationToken)
    {
        var questions = await _mediator.Send(
            new GetQuizBatchQuery(userId, topic),
            cancellationToken);

        return Ok(questions);
    }

    /// <summary>
    /// Сохраняет ответ пользователя и возвращает эталонный ответ.
    /// </summary>
    [HttpPost("answer")]
    [ProducesResponseType<SubmitAnswerResult>(StatusCodes.Status200OK)]
    public async Task<ActionResult<SubmitAnswerResult>> SubmitAnswer(
        [FromBody] SubmitAnswerRequest request,
        [FromHeader(Name = UserIdHeaderName)] string userId,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new SubmitAnswerCommand(
                userId,
                request.QuestionId,
                request.AnswerText),
            cancellationToken);

        return Ok(result);
    }
}
