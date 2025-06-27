namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response message for Operations.ListOperations.
/// </summary>
public class ListOperationsResponse
{
    /// <summary>
    /// The standard List next-page token.
    /// </summary>
    public string? NextPageToken { get; init; }

    /// <summary>
    /// A list of operations that matches the specified filter in the request.
    /// </summary>
    public IList<Operation>? Operations { get; init; }
}