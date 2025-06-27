namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A `Document` is a collection of `Chunk`s. A `Corpus` can have a maximum of 10,000 `Document`s.
/// </summary>
public class Document
{
    /// <summary>
    /// Output only. The Timestamp of when the `Document` was last updated.
    /// </summary>
    public System.DateTime? UpdateTime { get; init; }

    /// <summary>
    /// Output only. The Timestamp of when the `Document` was created.
    /// </summary>
    public System.DateTime? CreateTime { get; init; }

    /// <summary>
    /// Immutable. Identifier. The `Document` resource name. The ID (name excluding the "corpora/*/documents/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be derived from `display_name` along with a 12 character random suffix. Example: `corpora/{corpus_id}/documents/my-awesome-doc-123a456b789c`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Optional. User provided custom metadata stored as key-value pairs used for querying. A `Document` can have a maximum of 20 `CustomMetadata`.
    /// </summary>
    public IList<CustomMetadata>? CustomMetadata { get; init; }

    /// <summary>
    /// Optional. The human-readable display name for the `Document`. The display name must be no more than 512 characters in length, including spaces. Example: "Semantic Retriever Documentation"
    /// </summary>
    public string? DisplayName { get; init; }
}