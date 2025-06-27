namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `QueryDocument` containing a list of relevant chunks.
/// </summary>
public class QueryDocumentResponse
{
    /// <summary>
    /// The returned relevant chunks.
    /// </summary>
    public IList<RelevantChunk>? RelevantChunks { get; init; }
}