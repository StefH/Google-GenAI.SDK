namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Attribution for a source that contributed to an answer.
/// </summary>
public class GroundingAttribution
{
    /// <summary>
    /// Output only. Identifier for the source contributing to this attribution.
    /// </summary>
    public AttributionSourceId? SourceId { get; init; }

    /// <summary>
    /// Grounding source content that makes up this attribution.
    /// </summary>
    public Content? Content { get; init; }
}