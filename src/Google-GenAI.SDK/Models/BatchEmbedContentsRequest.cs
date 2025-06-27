namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Batch request to get embeddings from the model for a list of prompts.
/// </summary>
public class BatchEmbedContentsRequest
{
    /// <summary>
    /// Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.
    /// </summary>
    public required IList<EmbedContentRequest> Requests { get; init; }
}