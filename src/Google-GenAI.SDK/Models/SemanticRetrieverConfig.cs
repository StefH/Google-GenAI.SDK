namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Configuration for retrieving grounding content from a `Corpus` or `Document` created using the Semantic Retriever API.
/// </summary>
public class SemanticRetrieverConfig
{
    /// <summary>
    /// Required. Name of the resource for retrieval. Example: `corpora/123` or `corpora/123/documents/abc`.
    /// </summary>
    public required string Source { get; init; }

    /// <summary>
    /// Optional. Minimum relevance score for retrieved relevant `Chunk`s.
    /// </summary>
    public float? MinimumRelevanceScore { get; init; }

    /// <summary>
    /// Required. Query to use for matching `Chunk`s in the given resource by similarity.
    /// </summary>
    public required Content Query { get; init; }

    /// <summary>
    /// Optional. Maximum number of relevant `Chunk`s to retrieve.
    /// </summary>
    public int? MaxChunksCount { get; init; }

    /// <summary>
    /// Optional. Filters for selecting `Document`s and/or `Chunk`s from the resource.
    /// </summary>
    public IList<MetadataFilter>? MetadataFilters { get; init; }
}