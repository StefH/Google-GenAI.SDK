namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to get a text embedding from the model.
/// </summary>
public class EmbedTextRequest
{
    /// <summary>
    /// Optional. The free-form input text that the model will turn into an embedding.
    /// </summary>
    public string? Text { get; init; }
}