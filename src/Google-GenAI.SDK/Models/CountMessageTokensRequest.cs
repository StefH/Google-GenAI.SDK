namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Counts the number of tokens in the `prompt` sent to a model.  Models may tokenize text differently, so each model may return a different `token_count`.
/// </summary>
public class CountMessageTokensRequest
{
    /// <summary>
    /// Required. The prompt, whose token count is to be returned.
    /// </summary>
    public required MessagePrompt Prompt { get; init; }
}