namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The Tool configuration containing parameters for specifying `Tool` use in the request.
/// </summary>
public class ToolConfig
{
    /// <summary>
    /// Optional. Function calling config.
    /// </summary>
    public FunctionCallingConfig? FunctionCallingConfig { get; init; }
}