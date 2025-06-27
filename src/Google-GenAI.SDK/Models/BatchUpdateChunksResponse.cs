namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `BatchUpdateChunks` containing a list of updated `Chunk`s.
/// </summary>
public class BatchUpdateChunksResponse
{
    /// <summary>
    /// `Chunk`s updated.
    /// </summary>
    public IList<Chunk>? Chunks { get; init; }
}