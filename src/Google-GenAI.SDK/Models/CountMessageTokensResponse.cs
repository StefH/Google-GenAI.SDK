namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A response from `CountMessageTokens`.  It returns the model's `token_count` for the `prompt`.
/// </summary>
public class CountMessageTokensResponse
{
    /// <summary>
    /// The number of tokens that the `model` tokenizes the `prompt` into.  Always non-negative.
    /// </summary>
    public int? TokenCount { get; init; }
}