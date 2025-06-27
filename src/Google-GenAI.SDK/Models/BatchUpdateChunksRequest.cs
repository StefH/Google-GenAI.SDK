namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to batch update `Chunk`s.
/// </summary>
public class BatchUpdateChunksRequest
{
    /// <summary>
    /// Required. The request messages specifying the `Chunk`s to update. A maximum of 100 `Chunk`s can be updated in a batch.
    /// </summary>
    public required IList<UpdateChunkRequest> Requests { get; init; }
}