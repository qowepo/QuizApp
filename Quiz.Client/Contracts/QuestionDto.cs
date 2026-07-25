namespace Quiz.Client.Contracts;

/// <summary>
/// Вопрос без скрытого эталонного ответа.
/// </summary>
public sealed record QuestionDto(Guid Id, string Text);
