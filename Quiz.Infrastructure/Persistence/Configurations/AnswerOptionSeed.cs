using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Создаёт четыре детерминированных варианта для каждого вопроса.
/// </summary>
internal static class AnswerOptionSeed
{
    private static readonly int[] DistractorOffsets = [7, 17, 29];

    public static readonly IReadOnlyList<AnswerOptionSeedData> All =
        Build().ToArray();

    private static IEnumerable<AnswerOptionSeedData> Build()
    {
        foreach (var topicGroup in QuestionSeedCatalog.All.GroupBy(
                     question => question.Topic))
        {
            var questions = topicGroup
                .OrderBy(question => question.Sequence)
                .ToArray();

            if (questions.Length != 40)
            {
                throw new InvalidOperationException(
                    $"Topic {topicGroup.Key} must contain exactly 40 questions.");
            }

            for (var questionIndex = 0;
                 questionIndex < questions.Length;
                 questionIndex++)
            {
                var question = questions[questionIndex];
                var correctPosition = questionIndex % 4;
                var distractorIndex = 0;

                for (var position = 0; position < 4; position++)
                {
                    var isCorrect = position == correctPosition;
                    var source = isCorrect
                        ? question
                        : questions[
                            (questionIndex +
                             DistractorOffsets[distractorIndex++]) %
                            questions.Length];

                    yield return new AnswerOptionSeedData(
                        CreateOptionId(question, position + 1),
                        question.Id,
                        source.IdealAnswer,
                        isCorrect,
                        isCorrect
                            ? "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы."
                            : $"Этот вариант технически корректен, но раскрывает другой вопрос: «{source.Text}». Поэтому он не отвечает на текущую формулировку.");
                }
            }
        }
    }

    private static Guid CreateOptionId(
        QuestionSeedData question,
        int position)
    {
        var topicNumber = ((int)question.Topic) + 1;
        var optionSequence = question.Sequence * 10 + position;

        return Guid.Parse(
            $"{topicNumber}1000000-0000-0000-0000-{optionSequence:000000000000}");
    }
}

internal sealed record AnswerOptionSeedData(
    Guid Id,
    Guid QuestionId,
    string Text,
    bool IsCorrect,
    string Explanation);
