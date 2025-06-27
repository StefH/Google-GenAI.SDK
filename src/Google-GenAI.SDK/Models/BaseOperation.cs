namespace GoogleGenAI.SDK.Models;

/// <summary>
/// This resource represents a long-running operation that is the result of a network API call.
/// </summary>
public class BaseOperation
{
    /// <summary>
    /// The server-assigned name, which is only unique within the same service that originally returns it. If you use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// The error result of the operation in case of failure or cancellation.
    /// </summary>
    public Status? Error { get; init; }

    /// <summary>
    /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed, and either `error` or `response` is available.
    /// </summary>
    public bool? Done { get; init; }
}