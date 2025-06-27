namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A `Corpus` is a collection of `Document`s. A project can create up to 5 corpora.
/// </summary>
public class Corpus
{
    /// <summary>
    /// Optional. The human-readable display name for the `Corpus`. The display name must be no more than 512 characters in length, including spaces. Example: "Docs on Semantic Retriever"
    /// </summary>
    public string? DisplayName { get; init; }

    /// <summary>
    /// Immutable. Identifier. The `Corpus` resource name. The ID (name excluding the "corpora/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be derived from `display_name` along with a 12 character random suffix. Example: `corpora/my-awesome-corpora-123a456b789c`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Output only. The Timestamp of when the `Corpus` was created.
    /// </summary>
    public System.DateTime? CreateTime { get; init; }

    /// <summary>
    /// Output only. The Timestamp of when the `Corpus` was last updated.
    /// </summary>
    public System.DateTime? UpdateTime { get; init; }
}