namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to batch delete `Chunk`s.
/// </summary>
public class BatchDeleteChunksRequest
{
    /// <summary>
    /// Required. The request messages specifying the `Chunk`s to delete.
    /// </summary>
    public required IList<DeleteChunkRequest> Requests { get; init; }
}