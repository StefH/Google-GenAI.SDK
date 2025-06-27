namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to batch create `Chunk`s.
/// </summary>
public class BatchCreateChunksRequest
{
    /// <summary>
    /// Required. The request messages specifying the `Chunk`s to create. A maximum of 100 `Chunk`s can be created in a batch.
    /// </summary>
    public required IList<CreateChunkRequest> Requests { get; init; }
}