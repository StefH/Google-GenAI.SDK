namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Veo response.
/// </summary>
public class GenerateVideoResponse
{
    /// <summary>
    /// The generated samples.
    /// </summary>
    public IList<Media>? GeneratedSamples { get; init; }

    /// <summary>
    /// Returns if any videos were filtered due to RAI policies.
    /// </summary>
    public int? RaiMediaFilteredCount { get; init; }

    /// <summary>
    /// Returns rai failure reasons if any.
    /// </summary>
    public IList<string>? RaiMediaFilteredReasons { get; init; }
}