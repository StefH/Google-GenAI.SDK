namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Configuration for specifying function calling behavior.
/// </summary>
public class FunctionCallingConfig
{
    /// <summary>
    /// Optional. A set of function names that, when provided, limits the functions the model will call.  This should only be set when the Mode is ANY. Function names should match [FunctionDeclaration.name]. With mode set to ANY, model will predict a function call from the set of function names provided.
    /// </summary>
    public IList<string>? AllowedFunctionNames { get; init; }

    /// <summary>
    /// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
    /// </summary>
    public FunctionCallingConfigMode? Mode { get; init; }
}