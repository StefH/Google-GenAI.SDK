namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A single example for tuning.
/// </summary>
public class TuningExample
{
    /// <summary>
    /// Optional. Text model input.
    /// </summary>
    public string? TextInput { get; init; }

    /// <summary>
    /// Required. The expected model output.
    /// </summary>
    public required string Output { get; init; }
}