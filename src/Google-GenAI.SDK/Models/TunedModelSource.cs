namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Tuned model as a source for training a new model.
/// </summary>
public class TunedModelSource
{
    /// <summary>
    /// Immutable. The name of the `TunedModel` to use as the starting point for training the new model. Example: `tunedModels/my-tuned-model`
    /// </summary>
    public string? TunedModel { get; init; }

    /// <summary>
    /// Output only. The name of the base `Model` this `TunedModel` was tuned from. Example: `models/gemini-1.5-flash-001`
    /// </summary>
    public string? BaseModel { get; init; }
}