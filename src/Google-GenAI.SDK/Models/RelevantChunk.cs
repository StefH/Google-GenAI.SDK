namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The information for a chunk relevant to a query.
/// </summary>
public class RelevantChunk
{
    /// <summary>
    /// `Chunk` relevance to the query.
    /// </summary>
    public float? ChunkRelevanceScore { get; init; }

    /// <summary>
    /// `Chunk` associated with the query.
    /// </summary>
    public Chunk? Chunk { get; init; }
}