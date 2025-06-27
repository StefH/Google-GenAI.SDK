namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Metadata returned to client when grounding is enabled.
/// </summary>
public class GroundingMetadata
{
    /// <summary>
    /// Web search queries for the following-up web search.
    /// </summary>
    public IList<string>? WebSearchQueries { get; init; }

    /// <summary>
    /// List of supporting references retrieved from specified grounding source.
    /// </summary>
    public IList<GroundingChunk>? GroundingChunks { get; init; }

    /// <summary>
    /// List of grounding support.
    /// </summary>
    public IList<GroundingSupport>? GroundingSupports { get; init; }

    /// <summary>
    /// Optional. Google search entry for the following-up web searches.
    /// </summary>
    public SearchEntryPoint? SearchEntryPoint { get; init; }

    /// <summary>
    /// Metadata related to retrieval in the grounding flow.
    /// </summary>
    public RetrievalMetadata? RetrievalMetadata { get; init; }
}