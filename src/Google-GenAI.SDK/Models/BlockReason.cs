namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase the prompt.
/// </summary>
public enum BlockReason
{
    /// <summary>
    /// Default value. This value is unused.
    /// </summary>
    BLOCK_REASON_UNSPECIFIED,

    /// <summary>
    /// Prompt was blocked due to safety reasons. Inspect `safety_ratings` to understand which safety category blocked it.
    /// </summary>
    SAFETY,

    /// <summary>
    /// Prompt was blocked due to unknown reasons.
    /// </summary>
    OTHER,

    /// <summary>
    /// Prompt was blocked due to the terms which are included from the terminology blocklist.
    /// </summary>
    BLOCKLIST,

    /// <summary>
    /// Prompt was blocked due to prohibited content.
    /// </summary>
    PROHIBITED_CONTENT,

    /// <summary>
    /// Candidates blocked due to unsafe image generation content.
    /// </summary>
    IMAGE_SAFETY,
}