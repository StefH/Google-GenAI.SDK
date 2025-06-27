namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Counts the number of tokens in the `prompt` sent to a model.  Models may tokenize text differently, so each model may return a different `token_count`.
/// </summary>
public class CountTextTokensRequest
{
    /// <summary>
    /// Required. The free-form input text given to the model as a prompt.
    /// </summary>
    public required TextPrompt Prompt { get; init; }
}