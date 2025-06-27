namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response to a EmbedTextRequest.
/// </summary>
public class EmbedTextResponse
{
    /// <summary>
    /// Output only. The embedding generated from the input text.
    /// </summary>
    public Embedding? Embedding { get; init; }
}