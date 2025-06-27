namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request containing the `Content` for the model to embed.
/// </summary>
public class EmbedContentRequest
{
    /// <summary>
    /// Required. The content to embed. Only the `parts.text` fields will be counted.
    /// </summary>
    public required Content Content { get; init; }

    /// <summary>
    /// Optional. Optional reduced dimension for the output embedding. If set, excessive values in the output embedding are truncated from the end. Supported by newer models since 2024 only. You cannot set this value if using the earlier model (`models/embedding-001`).
    /// </summary>
    public int? OutputDimensionality { get; init; }

    /// <summary>
    /// Optional. An optional title for the text. Only applicable when TaskType is `RETRIEVAL_DOCUMENT`.  Note: Specifying a `title` for `RETRIEVAL_DOCUMENT` provides better quality embeddings for retrieval.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// Optional. Optional task type for which the embeddings will be used. Not supported on earlier models (`models/embedding-001`).
    /// </summary>
    public TaskType? TaskType { get; init; }
}