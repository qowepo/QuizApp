using System.Reflection;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Представляет типизированный каталог сидов для вопросов и вариантов ответа.
/// </summary>
internal static class QuestionSeedCatalog
{
    public static readonly IReadOnlyList<QuestionSeedData> All =
        MvpQuestionSeed.All
            .Concat(SeniorQuestionSeed.All)
            .Concat(CodeAnalysisQuestionSeed.All)
            .Select(ToQuestionSeedData)
            .OrderBy(item => item.Topic)
            .ThenBy(item => item.Sequence)
            .ToArray();

    private static QuestionSeedData ToQuestionSeedData(object seed)
    {
        var seedType = seed.GetType();
        var id = Read<Guid>(seed, seedType, "Id");
        var sequence = int.Parse(id.ToString("N")[^12..]);

        return new QuestionSeedData(
            id,
            Read<Topic>(seed, seedType, "Topic"),
            ReadOptional<Difficulty>(seed, seedType, "Difficulty") ??
            ResolveDifficulty(sequence),
            Read<string>(seed, seedType, "Text"),
            Read<string>(seed, seedType, "IdealAnswer"),
            sequence);
    }

    private static T Read<T>(
        object seed,
        Type seedType,
        string propertyName)
    {
        var property = seedType.GetProperty(
            propertyName,
            BindingFlags.Instance | BindingFlags.Public);

        if (property?.GetValue(seed) is not T value)
        {
            throw new InvalidOperationException(
                $"Question seed property '{propertyName}' is missing.");
        }

        return value;
    }

    private static T? ReadOptional<T>(
        object seed,
        Type seedType,
        string propertyName)
        where T : struct
    {
        var property = seedType.GetProperty(
            propertyName,
            BindingFlags.Instance | BindingFlags.Public);

        return property?.GetValue(seed) is T value
            ? value
            : null;
    }

    private static Difficulty ResolveDifficulty(int sequence)
    {
        return sequence switch
        {
            <= 10 => Difficulty.Middle,
            <= 20 => Difficulty.MiddlePlus,
            <= 30 => Difficulty.Senior,
            _ => Difficulty.SeniorPlus
        };
    }
}

internal sealed record QuestionSeedData(
    Guid Id,
    Topic Topic,
    Difficulty Difficulty,
    string Text,
    string IdealAnswer,
    int Sequence);
