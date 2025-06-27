namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Dataset for training or validation.
/// </summary>
public class Dataset
{
    /// <summary>
    /// Optional. Inline examples with simple input/output text.
    /// </summary>
    public TuningExamples? Examples { get; init; }
}