namespace Quiz.Identity.Application.Authorization;

public static class IdentityRoles
{
    public const string Student = "Student";
    public const string ContentEditor = "ContentEditor";
    public const string Administrator = "Administrator";

    public static readonly IReadOnlyCollection<string> All =
        [Student, ContentEditor, Administrator];
}

public static class IdentityScopes
{
    public const string QuizRead = "quiz.read";
    public const string QuizAnswer = "quiz.answer";
    public const string ProgressRead = "progress.read";
    public const string QuestionsManage = "questions.manage";

    public static readonly IReadOnlyCollection<string> All =
        [QuizRead, QuizAnswer, ProgressRead, QuestionsManage];
}

public static class IdentityResources
{
    public const string QuizApi = "quiz-api";
}
