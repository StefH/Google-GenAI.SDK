namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response to a EmbedTextRequest.
/// </summary>
public class BatchEmbedTextResponse
{
    /// <summary>
    /// Output only. The embeddings generated from the input text.
    /// </summary>
    public IList<Embedding>? Embeddings { get; init; }
}