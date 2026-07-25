using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Создаёт четыре детерминированных варианта для каждого вопроса.
/// </summary>
internal static class AnswerOptionSeed
{
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

            for (var questionIndex = 0;
                 questionIndex < questions.Length;
                 questionIndex++)
            {
                var question = questions[questionIndex];
                var correctPosition = questionIndex % 4;
                var distractorIndex = 0;
                var distractors = QuestionDistractorCatalog.Get(question);

                for (var position = 0; position < 4; position++)
                {
                    var isCorrect = position == correctPosition;
                    var optionText = isCorrect
                        ? question.IdealAnswer
                        : distractors[distractorIndex++];

                    yield return new AnswerOptionSeedData(
                        CreateOptionId(question, position + 1),
                        question.Id,
                        optionText,
                        isCorrect,
                        isCorrect
                            ? "Этот вариант напрямую отвечает на поставленный вопрос и учитывает ключевые ограничения и компромиссы."
                            : "Этот вариант относится к поставленному вопросу, но содержит неверную гарантию, условие или причинно-следственную связь. Сравните его с подробным разбором ниже.");
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
