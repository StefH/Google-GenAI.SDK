namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response to an `EmbedContentRequest`.
/// </summary>
public class EmbedContentResponse
{
    /// <summary>
    /// Output only. The embedding generated from the input content.
    /// </summary>
    public ContentEmbedding? Embedding { get; init; }
}