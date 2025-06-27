namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A `Chunk` is a subpart of a `Document` that is treated as an independent unit for the purposes of vector representation and storage. A `Corpus` can have a maximum of 1 million `Chunk`s.
/// </summary>
public class Chunk
{
    /// <summary>
    /// Immutable. Identifier. The `Chunk` resource name. The ID (name excluding the "corpora/*/documents/*/chunks/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a random 12-character unique ID will be generated. Example: `corpora/{corpus_id}/documents/{document_id}/chunks/123a456b789c`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Required. The content for the `Chunk`, such as the text string. The maximum number of tokens per chunk is 2043.
    /// </summary>
    public required ChunkData Data { get; init; }

    /// <summary>
    /// Output only. Current state of the `Chunk`.
    /// </summary>
    public ChunkState? State { get; init; }

    /// <summary>
    /// Optional. User provided custom metadata stored as key-value pairs. The maximum number of `CustomMetadata` per chunk is 20.
    /// </summary>
    public IList<CustomMetadata>? CustomMetadata { get; init; }

    /// <summary>
    /// Output only. The Timestamp of when the `Chunk` was created.
    /// </summary>
    public System.DateTime? CreateTime { get; init; }

    /// <summary>
    /// Output only. The Timestamp of when the `Chunk` was last updated.
    /// </summary>
    public System.DateTime? UpdateTime { get; init; }
}