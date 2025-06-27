namespace GoogleGenAI.SDK.Models;

/// <summary>
/// This resource represents a long-running operation that is the result of a network API call.
/// </summary>
public class Operation : BaseOperation
{
    /// <summary>
    /// The normal, successful response of the operation.  If the original method returns no data on success, such as `Delete`, the response is `google.protobuf.Empty`.  If the original method is standard `Get`/`Create`/`Update`, the response should be the resource.  For other methods, the response should have the type `XxxResponse`, where `Xxx` is the original method name.  For example, if the original method name is `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
    /// </summary>
    public IDictionary<string, object?>? Response { get; init; }

    /// <summary>
    /// Service-specific metadata associated with the operation.  It typically contains progress information and common metadata such as create time. Some services might not provide such metadata.  Any method that returns a long-running operation should document the metadata type, if any.
    /// </summary>
    public IDictionary<string, object?>? Metadata { get; init; }
}