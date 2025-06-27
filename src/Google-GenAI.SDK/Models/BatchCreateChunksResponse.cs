namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `BatchCreateChunks` containing a list of created `Chunk`s.
/// </summary>
public class BatchCreateChunksResponse
{
    /// <summary>
    /// `Chunk`s created.
    /// </summary>
    public IList<Chunk>? Chunks { get; init; }
}