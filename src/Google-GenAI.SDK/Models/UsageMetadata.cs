namespace GoogleGenAI.SDK.Models;

public class UsageMetadata
{
    public int PromptTokenCount { get; set; }

    public int CandidatesTokenCount { get; set; }

    public int TotalTokenCount { get; set; }

    public required List<PromptTokensDetail> PromptTokensDetails { get; set; }

    public required List<CandidatesTokensDetail> CandidatesTokensDetails { get; set; }
}