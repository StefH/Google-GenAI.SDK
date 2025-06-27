namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A predicted `FunctionCall` returned from the model that contains a string representing the `FunctionDeclaration.name` with the arguments and their values.
/// </summary>
public class FunctionCall
{
    /// <summary>
    /// Optional. The function parameters and values in JSON object format.
    /// </summary>
    public IDictionary<string, object?>? Args { get; init; }

    /// <summary>
    /// Required. The name of the function to call. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 63.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Optional. The unique id of the function call. If populated, the client to execute the `function_call` and return the response with the matching `id`.
    /// </summary>
    public string? Id { get; init; }
}