namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A response from `CountTokens`.  It returns the model's `token_count` for the `prompt`.
/// </summary>
public class CountTokensResponse
{
    /// <summary>
    /// The number of tokens that the `Model` tokenizes the `prompt` into. Always non-negative.
    /// </summary>
    public int? TotalTokens { get; init; }

    /// <summary>
    /// Number of tokens in the cached part of the prompt (the cached content).
    /// </summary>
    public int? CachedContentTokenCount { get; init; }

    /// <summary>
    /// Output only. List of modalities that were processed in the cached content.
    /// </summary>
    public IList<ModalityTokenCount>? CacheTokensDetails { get; init; }

    /// <summary>
    /// Output only. List of modalities that were processed in the request input.
    /// </summary>
    public IList<ModalityTokenCount>? PromptTokensDetails { get; init; }
}