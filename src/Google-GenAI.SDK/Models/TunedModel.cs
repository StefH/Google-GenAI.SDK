namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A fine-tuned model created using ModelService.CreateTunedModel.
/// </summary>
public class TunedModel
{
    /// <summary>
    /// Optional. Controls the randomness of the output.  Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model.  This value specifies default to be the one used by the base model while creating the model.
    /// </summary>
    public float? Temperature { get; init; }

    /// <summary>
    /// Output only. The timestamp when this model was created.
    /// </summary>
    public System.DateTime? CreateTime { get; init; }

    /// <summary>
    /// Immutable. The name of the `Model` to tune. Example: `models/gemini-1.5-flash-001`
    /// </summary>
    public string? BaseModel { get; init; }

    /// <summary>
    /// Optional. For Nucleus sampling.  Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`.  This value specifies default to be the one used by the base model while creating the model.
    /// </summary>
    public float? TopP { get; init; }

    /// <summary>
    /// Optional. A short description of this model.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Output only. The state of the tuned model.
    /// </summary>
    public TunedModelState? State { get; init; }

    /// <summary>
    /// Optional. TunedModel to use as the starting point for training the new model.
    /// </summary>
    public TunedModelSource? TunedModelSource { get; init; }

    /// <summary>
    /// Optional. The name to display for this model in user interfaces. The display name must be up to 40 characters including spaces.
    /// </summary>
    public string? DisplayName { get; init; }

    /// <summary>
    /// Output only. The tuned model name. A unique name will be generated on create. Example: `tunedModels/az2mb0bpw6i` If display_name is set on create, the id portion of the name will be set by concatenating the words of the display_name with hyphens and adding a random portion for uniqueness.  Example:   * display_name = `Sentence Translator`  * name = `tunedModels/sentence-translator-u3b7m`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Optional. List of project numbers that have read access to the tuned model.
    /// </summary>
    public IList<long>? ReaderProjectNumbers { get; init; }

    /// <summary>
    /// Optional. For Top-k sampling.  Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model.  This value specifies default to be the one used by the base model while creating the model.
    /// </summary>
    public int? TopK { get; init; }

    /// <summary>
    /// Output only. The timestamp when this model was updated.
    /// </summary>
    public System.DateTime? UpdateTime { get; init; }

    /// <summary>
    /// Required. The tuning task that creates the tuned model.
    /// </summary>
    public required TuningTask TuningTask { get; init; }
}