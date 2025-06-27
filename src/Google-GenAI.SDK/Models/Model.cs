namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Information about a Generative Language Model.
/// </summary>
public class Model
{
    /// <summary>
    /// Required. The version number of the model.  This represents the major version (`1.0` or `1.5`)
    /// </summary>
    public required string Version { get; init; }

    /// <summary>
    /// The maximum temperature this model can use.
    /// </summary>
    public float? MaxTemperature { get; init; }

    /// <summary>
    /// The model's supported generation methods.  The corresponding API method names are defined as Pascal case strings, such as `generateMessage` and `generateContent`.
    /// </summary>
    public IList<string>? SupportedGenerationMethods { get; init; }

    /// <summary>
    /// Maximum number of output tokens available for this model.
    /// </summary>
    public int? OutputTokenLimit { get; init; }

    /// <summary>
    /// Required. The resource name of the `Model`. Refer to [Model variants](https://ai.google.dev/gemini-api/docs/models/gemini#model-variations) for all allowed values.  Format: `models/{model}` with a `{model}` naming convention of:  * "{base_model_id}-{version}"  Examples:  * `models/gemini-1.5-flash-001`
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Maximum number of input tokens allowed for this model.
    /// </summary>
    public int? InputTokenLimit { get; init; }

    /// <summary>
    /// The human-readable name of the model. E.g. "Gemini 1.5 Flash".  The name can be up to 128 characters long and can consist of any UTF-8 characters.
    /// </summary>
    public string? DisplayName { get; init; }

    /// <summary>
    /// For [Nucleus sampling](https://ai.google.dev/gemini-api/docs/prompting-strategies#top-p).  Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be used by the backend while making the call to the model.
    /// </summary>
    public float? TopP { get; init; }

    /// <summary>
    /// A short description of the model.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Controls the randomness of the output.  Values can range over `[0.0,max_temperature]`, inclusive. A higher value will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be used by the backend while making the call to the model.
    /// </summary>
    public float? Temperature { get; init; }

    /// <summary>
    /// Required. The name of the base model, pass this to the generation request.  Examples:  * `gemini-1.5-flash`
    /// </summary>
    public required string BaseModelId { get; init; }

    /// <summary>
    /// For Top-k sampling.  Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model. If empty, indicates the model doesn't use top-k sampling, and `top_k` isn't allowed as a generation parameter.
    /// </summary>
    public int? TopK { get; init; }

    /// <summary>
    /// Whether the model supports thinking.
    /// </summary>
    public bool? Thinking { get; init; }
}