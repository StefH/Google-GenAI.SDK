namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A repeated list of passages.
/// </summary>
public class GroundingPassages
{
    /// <summary>
    /// List of passages.
    /// </summary>
    public IList<GroundingPassage>? Passages { get; init; }
}