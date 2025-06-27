namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Record for a single tuning step.
/// </summary>
public class TuningSnapshot
{
    /// <summary>
    /// Output only. The epoch this step was part of.
    /// </summary>
    public int? Epoch { get; init; }

    /// <summary>
    /// Output only. The timestamp when this metric was computed.
    /// </summary>
    public System.DateTime? ComputeTime { get; init; }

    /// <summary>
    /// Output only. The mean loss of the training examples for this step.
    /// </summary>
    public float? MeanLoss { get; init; }

    /// <summary>
    /// Output only. The tuning step.
    /// </summary>
    public int? Step { get; init; }
}