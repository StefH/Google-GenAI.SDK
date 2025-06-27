namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The mode of the predictor to be used in dynamic retrieval.
/// </summary>
public enum DynamicRetrievalMode
{
    /// <summary>
    /// Always trigger retrieval.
    /// </summary>
    MODE_UNSPECIFIED,

    /// <summary>
    /// Run retrieval only when system decides it is necessary.
    /// </summary>
    MODE_DYNAMIC,
}