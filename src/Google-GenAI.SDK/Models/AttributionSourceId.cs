namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Identifier for the source contributing to this attribution.
/// </summary>
public class AttributionSourceId
{
    /// <summary>
    /// Identifier for an inline passage.
    /// </summary>
    public GroundingPassageId? GroundingPassage { get; init; }

    /// <summary>
    /// Identifier for a `Chunk` fetched via Semantic Retriever.
    /// </summary>
    public SemanticRetrieverChunk? SemanticRetrieverChunk { get; init; }
}