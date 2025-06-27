namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Candidates with top log probabilities at each decoding step.
/// </summary>
public class TopCandidates
{
    /// <summary>
    /// Sorted by log probability in descending order.
    /// </summary>
    public IList<LogprobsResultCandidate>? Candidates { get; init; }
}