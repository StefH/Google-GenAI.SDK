namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. Outcome of the code execution.
/// </summary>
public enum Outcome
{
    /// <summary>
    /// Unspecified status. This value should not be used.
    /// </summary>
    OUTCOME_UNSPECIFIED,

    /// <summary>
    /// Code execution completed successfully.
    /// </summary>
    OUTCOME_OK,

    /// <summary>
    /// Code execution finished but with a failure. `stderr` should contain the reason.
    /// </summary>
    OUTCOME_FAILED,

    /// <summary>
    /// Code execution ran for too long, and was cancelled. There may or may not be a partial output present.
    /// </summary>
    OUTCOME_DEADLINE_EXCEEDED,
}