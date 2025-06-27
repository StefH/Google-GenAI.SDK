namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Result of executing the `ExecutableCode`.  Only generated when using the `CodeExecution`, and always follows a `part` containing the `ExecutableCode`.
/// </summary>
public class CodeExecutionResult
{
    /// <summary>
    /// Required. Outcome of the code execution.
    /// </summary>
    public required Outcome Outcome { get; init; }

    /// <summary>
    /// Optional. Contains stdout when code execution is successful, stderr or other description otherwise.
    /// </summary>
    public string? Output { get; init; }
}