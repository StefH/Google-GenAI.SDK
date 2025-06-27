namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Tuning tasks that create tuned models.
/// </summary>
public class TuningTask
{
    /// <summary>
    /// Output only. The timestamp when tuning this model completed.
    /// </summary>
    public System.DateTime? CompleteTime { get; init; }

    /// <summary>
    /// Required. Input only. Immutable. The model training data.
    /// </summary>
    public required Dataset TrainingData { get; init; }

    /// <summary>
    /// Output only. The timestamp when tuning this model started.
    /// </summary>
    public System.DateTime? StartTime { get; init; }

    /// <summary>
    /// Output only. Metrics collected during tuning.
    /// </summary>
    public IList<TuningSnapshot>? Snapshots { get; init; }

    /// <summary>
    /// Immutable. Hyperparameters controlling the tuning process. If not provided, default values will be used.
    /// </summary>
    public Hyperparameters? Hyperparameters { get; init; }
}