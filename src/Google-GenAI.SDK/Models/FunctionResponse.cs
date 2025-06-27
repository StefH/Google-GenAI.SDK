namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The result output from a `FunctionCall` that contains a string representing the `FunctionDeclaration.name` and a structured JSON object containing any output from the function is used as context to the model. This should contain the result of a`FunctionCall` made based on model prediction.
/// </summary>
public class FunctionResponse
{
    /// <summary>
    /// Required. The function response in JSON object format.
    /// </summary>
    public required IDictionary<string, object> Response { get; init; }

    /// <summary>
    /// Optional. Signals that function call continues, and more responses will be returned, turning the function call into a generator. Is only applicable to NON_BLOCKING function calls, is ignored otherwise. If set to false, future responses will not be considered. It is allowed to return empty `response` with `will_continue=False` to signal that the function call is finished. This may still trigger the model generation. To avoid triggering the generation and finish the function call, additionally set `scheduling` to `SILENT`.
    /// </summary>
    public bool? WillContinue { get; init; }

    /// <summary>
    /// Optional. Specifies how the response should be scheduled in the conversation. Only applicable to NON_BLOCKING function calls, is ignored otherwise. Defaults to WHEN_IDLE.
    /// </summary>
    public Scheduling? Scheduling { get; init; }

    /// <summary>
    /// Required. The name of the function to call. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 63.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Optional. The id of the function call this response is for. Populated by the client to match the corresponding function call `id`.
    /// </summary>
    public string? Id { get; init; }
}