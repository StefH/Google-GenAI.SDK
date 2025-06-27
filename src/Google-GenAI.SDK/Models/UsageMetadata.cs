namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Metadata on the generation request's token usage.
/// </summary>
public class UsageMetadata
{
    /// <summary>
    /// Output only. List of modalities of the cached content in the request input.
    /// </summary>
    public IList<ModalityTokenCount>? CacheTokensDetails { get; init; }

    /// <summary>
    /// Number of tokens in the prompt. When `cached_content` is set, this is still the total effective prompt size meaning this includes the number of tokens in the cached content.
    /// </summary>
    public int? PromptTokenCount { get; init; }

    /// <summary>
    /// Output only. List of modalities that were processed for tool-use request inputs.
    /// </summary>
    public IList<ModalityTokenCount>? ToolUsePromptTokensDetails { get; init; }

    /// <summary>
    /// Number of tokens in the cached part of the prompt (the cached content)
    /// </summary>
    public int? CachedContentTokenCount { get; init; }

    /// <summary>
    /// Output only. Number of tokens present in tool-use prompt(s).
    /// </summary>
    public int? ToolUsePromptTokenCount { get; init; }

    /// <summary>
    /// Total number of tokens across all the generated response candidates.
    /// </summary>
    public int? CandidatesTokenCount { get; init; }

    /// <summary>
    /// Output only. List of modalities that were processed in the request input.
    /// </summary>
    public IList<ModalityTokenCount>? PromptTokensDetails { get; init; }

    /// <summary>
    /// Output only. Number of tokens of thoughts for thinking models.
    /// </summary>
    public int? ThoughtsTokenCount { get; init; }

    /// <summary>
    /// Output only. List of modalities that were returned in the response.
    /// </summary>
    public IList<ModalityTokenCount>? CandidatesTokensDetails { get; init; }

    /// <summary>
    /// Total token count for the generation request (prompt + response candidates).
    /// </summary>
    public int? TotalTokenCount { get; init; }
}