namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A response from `CountTextTokens`.  It returns the model's `token_count` for the `prompt`.
/// </summary>
public class CountTextTokensResponse
{
    /// <summary>
    /// The number of tokens that the `model` tokenizes the `prompt` into.  Always non-negative.
    /// </summary>
    public int? TokenCount { get; init; }
}