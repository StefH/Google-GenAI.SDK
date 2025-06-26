namespace GoogleGenAI.SDK.Models;

public class Candidate
{
    public required Content Content { get; init; }

    public required string FinishReason { get; init; }

    public float AvgLogprobs { get; init; }
}