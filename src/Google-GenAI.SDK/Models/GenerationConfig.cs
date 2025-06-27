namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
/// </summary>
public class GenerationConfig
{
    /// <summary>
    /// Optional. Output schema of the generated candidate text. Schemas must be a subset of the [OpenAPI schema](https://spec.openapis.org/oas/v3.0.3#schema) and can be objects, primitives or arrays.  If set, a compatible `response_mime_type` must also be set. Compatible MIME types: `application/json`: Schema for JSON response. Refer to the [JSON text generation guide](https://ai.google.dev/gemini-api/docs/json-mode) for more details.
    /// </summary>
    public Schema? ResponseSchema { get; init; }

    /// <summary>
    /// Optional. Enables enhanced civic answers. It may not be available for all models.
    /// </summary>
    public bool? EnableEnhancedCivicAnswers { get; init; }

    /// <summary>
    /// Optional. If specified, the media resolution specified will be used.
    /// </summary>
    public MediaResolution? MediaResolution { get; init; }

    /// <summary>
    /// Optional. Presence penalty applied to the next token's logprobs if the token has already been seen in the response.  This penalty is binary on/off and not dependant on the number of times the token is used (after the first). Use frequency_penalty for a penalty that increases with each use.  A positive penalty will discourage the use of tokens that have already been used in the response, increasing the vocabulary.  A negative penalty will encourage the use of tokens that have already been used in the response, decreasing the vocabulary.
    /// </summary>
    public float? PresencePenalty { get; init; }

    /// <summary>
    /// Optional. The speech generation config.
    /// </summary>
    public SpeechConfig? SpeechConfig { get; init; }

    /// <summary>
    /// Optional. The maximum number of tokens to include in a response candidate.  Note: The default value varies by model, see the `Model.output_token_limit` attribute of the `Model` returned from the `getModel` function.
    /// </summary>
    public int? MaxOutputTokens { get; init; }

    /// <summary>
    /// Optional. The maximum cumulative probability of tokens to consider when sampling.  The model uses combined Top-k and Top-p (nucleus) sampling.  Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits the number of tokens based on the cumulative probability.  Note: The default value varies by `Model` and is specified by the`Model.top_p` attribute returned from the `getModel` function. An empty `top_k` attribute indicates that the model doesn't apply top-k sampling and doesn't allow setting `top_k` on requests.
    /// </summary>
    public float? TopP { get; init; }

    /// <summary>
    /// Optional. Seed used in decoding. If not set, the request uses a randomly generated seed.
    /// </summary>
    public int? Seed { get; init; }

    /// <summary>
    /// Optional. If true, export the logprobs results in response.
    /// </summary>
    public bool? ResponseLogprobs { get; init; }

    /// <summary>
    /// Optional. Number of generated responses to return. If unset, this will default to 1. Please note that this doesn't work for previous generation models (Gemini 1.0 family)
    /// </summary>
    public int? CandidateCount { get; init; }

    /// <summary>
    /// Optional. Output schema of the generated response. This is an alternative to `response_schema` that accepts [JSON Schema](https://json-schema.org/).  If set, `response_schema` must be omitted, but `response_mime_type` is required.  While the full JSON Schema may be sent, not all features are supported. Specifically, only the following properties are supported:  - `$id` - `$defs` - `$ref` - `$anchor` - `type` - `format` - `title` - `description` - `enum` (for strings and numbers) - `items` - `prefixItems` - `minItems` - `maxItems` - `minimum` - `maximum` - `anyOf` - `oneOf` (interpreted the same as `anyOf`) - `properties` - `additionalProperties` - `required`  The non-standard `propertyOrdering` property may also be set.  Cyclic references are unrolled to a limited degree and, as such, may only be used within non-required properties. (Nullable properties are not sufficient.) If `$ref` is set on a sub-schema, no other properties, except for than those starting as a `$`, may be set.
    /// </summary>
    public object? ResponseJsonSchema { get; init; }

    /// <summary>
    /// Optional. Only valid if response_logprobs=True. This sets the number of top logprobs to return at each decoding step in the Candidate.logprobs_result.
    /// </summary>
    public int? Logprobs { get; init; }

    /// <summary>
    /// Optional. The maximum number of tokens to consider when sampling.  Gemini models use Top-p (nucleus) sampling or a combination of Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Models running with nucleus sampling don't allow top_k setting.  Note: The default value varies by `Model` and is specified by the`Model.top_p` attribute returned from the `getModel` function. An empty `top_k` attribute indicates that the model doesn't apply top-k sampling and doesn't allow setting `top_k` on requests.
    /// </summary>
    public int? TopK { get; init; }

    /// <summary>
    /// Optional. The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a `stop_sequence`. The stop sequence will not be included as part of the response.
    /// </summary>
    public IList<string>? StopSequences { get; init; }

    /// <summary>
    /// Optional. The requested modalities of the response. Represents the set of modalities that the model can return, and should be expected in the response. This is an exact match to the modalities of the response.  A model may have multiple combinations of supported modalities. If the requested modalities do not match any of the supported combinations, an error will be returned.  An empty list is equivalent to requesting only text.
    /// </summary>
    public IList<Modality>? ResponseModalities { get; init; }

    /// <summary>
    /// Optional. Controls the randomness of the output.  Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned from the `getModel` function.  Values can range from [0.0, 2.0].
    /// </summary>
    public float? Temperature { get; init; }

    /// <summary>
    /// Optional. MIME type of the generated candidate text. Supported MIME types are: `text/plain`: (default) Text output. `application/json`: JSON response in the response candidates. `text/x.enum`: ENUM as a string response in the response candidates. Refer to the [docs](https://ai.google.dev/gemini-api/docs/prompting_with_media#plain_text_formats) for a list of all supported text MIME types.
    /// </summary>
    public string? ResponseMimeType { get; init; }

    /// <summary>
    /// Optional. Frequency penalty applied to the next token's logprobs, multiplied by the number of times each token has been seen in the respponse so far.  A positive penalty will discourage the use of tokens that have already been used, proportional to the number of times the token has been used: The more a token is used, the more difficult it is for the model to use that token again increasing the vocabulary of responses.  Caution: A _negative_ penalty will encourage the model to reuse tokens proportional to the number of times the token has been used. Small negative values will reduce the vocabulary of a response. Larger negative values will cause the model to start repeating a common token  until it hits the max_output_tokens limit.
    /// </summary>
    public float? FrequencyPenalty { get; init; }

    /// <summary>
    /// Optional. Config for thinking features. An error will be returned if this field is set for models that don't support thinking.
    /// </summary>
    public ThinkingConfig? ThinkingConfig { get; init; }
}