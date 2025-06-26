namespace GoogleGenAI.SDK.Models;

public class GeminiResponse
{
    public required List<Candidate> Candidates { get; init; }

    public required UsageMetadata UsageMetadata { get; init; }

    public required string ModelVersion { get; init; }

    public required string ResponseId { get; init; }
}