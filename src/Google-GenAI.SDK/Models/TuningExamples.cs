namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A set of tuning examples. Can be training or validation data.
/// </summary>
public class TuningExamples
{
    /// <summary>
    /// The examples. Example input can be for text or discuss, but all examples in a set must be of the same type.
    /// </summary>
    public IList<TuningExample>? Examples { get; init; }
}