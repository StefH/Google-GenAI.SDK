namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Logprobs Result
/// </summary>
public class LogprobsResult
{
    /// <summary>
    /// Length = total number of decoding steps. The chosen candidates may or may not be in top_candidates.
    /// </summary>
    public IList<LogprobsResultCandidate>? ChosenCandidates { get; init; }

    /// <summary>
    /// Length = total number of decoding steps.
    /// </summary>
    public IList<TopCandidates>? TopCandidates { get; init; }
}