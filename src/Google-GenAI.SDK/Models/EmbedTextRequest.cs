namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to get a text embedding from the model.
/// </summary>
public class EmbedTextRequest
{
    /// <summary>
    /// Required. The model name to use with the format model=models/{model}.
    /// </summary>
    public required string Model { get; init; }

    /// <summary>
    /// Optional. The free-form input text that the model will turn into an embedding.
    /// </summary>
    public string? Text { get; init; }
}