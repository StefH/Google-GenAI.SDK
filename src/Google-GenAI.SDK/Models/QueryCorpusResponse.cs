namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `QueryCorpus` containing a list of relevant chunks.
/// </summary>
public class QueryCorpusResponse
{
    /// <summary>
    /// The relevant chunks.
    /// </summary>
    public IList<RelevantChunk>? RelevantChunks { get; init; }
}