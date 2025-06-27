namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to create a `Chunk`.
/// </summary>
public class CreateChunkRequest
{
    /// <summary>
    /// Required. The name of the `Document` where this `Chunk` will be created. Example: `corpora/my-corpus-123/documents/the-doc-abc`
    /// </summary>
    public required string Parent { get; init; }

    /// <summary>
    /// Required. The `Chunk` to create.
    /// </summary>
    public required Chunk Chunk { get; init; }
}