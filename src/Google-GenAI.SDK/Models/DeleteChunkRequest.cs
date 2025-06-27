namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to delete a `Chunk`.
/// </summary>
public class DeleteChunkRequest
{
    /// <summary>
    /// Required. The resource name of the `Chunk` to delete. Example: `corpora/my-corpus-123/documents/the-doc-abc/chunks/some-chunk`
    /// </summary>
    public required string Name { get; init; }
}