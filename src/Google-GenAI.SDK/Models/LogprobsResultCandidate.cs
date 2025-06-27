namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Candidate for the logprobs token and score.
/// </summary>
public class LogprobsResultCandidate
{
    /// <summary>
    /// The candidate’s token id value.
    /// </summary>
    public int? TokenId { get; init; }

    /// <summary>
    /// The candidate's log probability.
    /// </summary>
    public float? LogProbability { get; init; }

    /// <summary>
    /// The candidate’s token string value.
    /// </summary>
    public string? Token { get; init; }
}