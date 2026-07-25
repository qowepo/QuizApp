using System.Net.Http.Json;
using Microsoft.JSInterop;
using Quiz.Client.Contracts;

namespace Quiz.Client.Services;

/// <summary>
/// Типизированный клиент для взаимодействия с Quiz API.
/// </summary>
public sealed class QuizApiClient
{
    private const string UserIdHeaderName = "X-User-Id";
    private const string UserIdStorageKey = "quiz-app-user-id";

    private readonly HttpClient _httpClient;
    private readonly IJSRuntime _jsRuntime;

    public QuizApiClient(HttpClient httpClient, IJSRuntime jsRuntime)
    {
        _httpClient = httpClient;
        _jsRuntime = jsRuntime;
    }

    public async Task<List<QuestionDto>> StartQuizAsync(Topic topic)
    {
        using var request = new HttpRequestMessage(
            HttpMethod.Get,
            $"api/quiz/{Uri.EscapeDataString(topic.ToString())}/start");

        request.Headers.Add(UserIdHeaderName, await GetOrCreateUserIdAsync());

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<QuestionDto>>()
            ?? [];
    }

    public async Task<string> SubmitAnswerAsync(
        Guid questionId,
        string answerText)
    {
        using var request = new HttpRequestMessage(
            HttpMethod.Post,
            "api/quiz/answer")
        {
            Content = JsonContent.Create(
                new SubmitAnswerRequest(questionId, answerText))
        };

        request.Headers.Add(UserIdHeaderName, await GetOrCreateUserIdAsync());

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var result = await response.Content
            .ReadFromJsonAsync<SubmitAnswerResponse>();

        return result?.IdealAnswer
            ?? throw new InvalidDataException(
                "Quiz API returned an empty ideal answer.");
    }

    private async Task<string> GetOrCreateUserIdAsync()
    {
        var storedValue = await _jsRuntime.InvokeAsync<string?>(
            "localStorage.getItem",
            UserIdStorageKey);

        if (Guid.TryParse(storedValue, out var userId))
        {
            return userId.ToString();
        }

        var newUserId = Guid.NewGuid().ToString();

        await _jsRuntime.InvokeVoidAsync(
            "localStorage.setItem",
            UserIdStorageKey,
            newUserId);

        return newUserId;
    }
}
