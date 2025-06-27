namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response to a `BatchEmbedContentsRequest`.
/// </summary>
public class BatchEmbedContentsResponse
{
    /// <summary>
    /// Output only. The embeddings for each request, in the same order as provided in the batch request.
    /// </summary>
    public IList<ContentEmbedding>? Embeddings { get; init; }
}