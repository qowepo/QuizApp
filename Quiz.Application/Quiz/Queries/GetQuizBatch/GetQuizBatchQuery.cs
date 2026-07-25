using MediatR;
using Quiz.Domain.Questions;

namespace Quiz.Application.Quiz.Queries.GetQuizBatch;

/// <summary>
/// Запрос пяти случайных вопросов, на которые пользователь ещё не отвечал.
/// </summary>
public sealed record GetQuizBatchQuery(
    string UserId,
    Topic Topic) : IRequest<IReadOnlyList<QuizQuestionDto>>;
