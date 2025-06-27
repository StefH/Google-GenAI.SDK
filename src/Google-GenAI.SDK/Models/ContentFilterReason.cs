namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The reason content was blocked during request processing.
/// </summary>
public enum ContentFilterReason
{
    /// <summary>
    /// A blocked reason was not specified.
    /// </summary>
    BLOCKED_REASON_UNSPECIFIED,

    /// <summary>
    /// Content was blocked by safety settings.
    /// </summary>
    SAFETY,

    /// <summary>
    /// Content was blocked, but the reason is uncategorized.
    /// </summary>
    OTHER,
}