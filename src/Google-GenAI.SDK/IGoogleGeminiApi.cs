using GoogleGenAI.SDK.Models;
using RestEase;

namespace GoogleGenAI.SDK;

[Header("Content-Type", "application/json")]
public interface IGoogleGeminiApi
{
    [Query("key")]
    string Key { get; set; }

    [Post("models/{model}:generateContent")]
    Task<GeminiResponse> GenerateContentAsync([Path] string model, [Body] GeminiRequest request, CancellationToken cancellationToken = default);
}