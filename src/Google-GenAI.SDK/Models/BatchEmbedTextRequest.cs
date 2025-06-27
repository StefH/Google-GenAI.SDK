namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Batch request to get a text embedding from the model.
/// </summary>
public class BatchEmbedTextRequest
{
    /// <summary>
    /// Optional. The free-form input texts that the model will turn into an embedding. The current limit is 100 texts, over which an error will be thrown.
    /// </summary>
    public IList<string>? Texts { get; init; }

    /// <summary>
    /// Optional. Embed requests for the batch. Only one of `texts` or `requests` can be set.
    /// </summary>
    public IList<EmbedTextRequest>? Requests { get; init; }
}