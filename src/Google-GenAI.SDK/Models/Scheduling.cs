namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. Specifies how the response should be scheduled in the conversation. Only applicable to NON_BLOCKING function calls, is ignored otherwise. Defaults to WHEN_IDLE.
/// </summary>
public enum Scheduling
{
    /// <summary>
    /// This value is unused.
    /// </summary>
    SCHEDULING_UNSPECIFIED,

    /// <summary>
    /// Only add the result to the conversation context, do not interrupt or trigger generation.
    /// </summary>
    SILENT,

    /// <summary>
    /// Add the result to the conversation context, and prompt to generate output without interrupting ongoing generation.
    /// </summary>
    WHEN_IDLE,

    /// <summary>
    /// Add the result to the conversation context, interrupt ongoing generation and prompt to generate output.
    /// </summary>
    INTERRUPT,
}