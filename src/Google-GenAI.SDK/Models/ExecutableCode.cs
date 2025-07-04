﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Code generated by the model that is meant to be executed, and the result returned to the model.  Only generated when using the `CodeExecution` tool, in which the code will be automatically executed, and a corresponding `CodeExecutionResult` will also be generated.
/// </summary>
public class ExecutableCode
{
    /// <summary>
    /// Required. Programming language of the `code`.
    /// </summary>
    public required Language Language { get; init; }

    /// <summary>
    /// Required. The code to be executed.
    /// </summary>
    public required string Code { get; init; }
}