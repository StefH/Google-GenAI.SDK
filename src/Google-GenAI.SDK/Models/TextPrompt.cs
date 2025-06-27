namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Text given to the model as a prompt.  The Model will use this TextPrompt to Generate a text completion.
/// </summary>
public class TextPrompt
{
    /// <summary>
    /// Required. The prompt text.
    /// </summary>
    public required string Text { get; init; }
}