namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Metadata about the state and progress of creating a tuned model returned from the long-running operation
/// </summary>
public class CreateTunedModelMetadata
{
    /// <summary>
    /// Name of the tuned model associated with the tuning operation.
    /// </summary>
    public string? TunedModel { get; init; }

    /// <summary>
    /// The number of steps completed.
    /// </summary>
    public int? CompletedSteps { get; init; }

    /// <summary>
    /// The completed percentage for the tuning operation.
    /// </summary>
    public float? CompletedPercent { get; init; }

    /// <summary>
    /// Metrics collected during tuning.
    /// </summary>
    public IList<TuningSnapshot>? Snapshots { get; init; }

    /// <summary>
    /// The total number of tuning steps.
    /// </summary>
    public int? TotalSteps { get; init; }
}