namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Counts the number of tokens in the `prompt` sent to a model.  Models may tokenize text differently, so each model may return a different `token_count`.
/// </summary>
public class CountTokensRequest
{
    /// <summary>
    /// Optional. The input given to the model as a prompt. This field is ignored when `generate_content_request` is set.
    /// </summary>
    public IList<Content>? Contents { get; init; }

    /// <summary>
    /// Optional. The overall input given to the `Model`. This includes the prompt as well as other model steering information like [system instructions](https://ai.google.dev/gemini-api/docs/system-instructions), and/or function declarations for [function calling](https://ai.google.dev/gemini-api/docs/function-calling). `Model`s/`Content`s and `generate_content_request`s are mutually exclusive. You can either send `Model` + `Content`s or a `generate_content_request`, but never both.
    /// </summary>
    public GenerateContentRequest? GenerateContentRequest { get; init; }
}