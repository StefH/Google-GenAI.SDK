namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Context of the a single url retrieval.
/// </summary>
public class UrlMetadata
{
    /// <summary>
    /// Retrieved url by the tool.
    /// </summary>
    public string? RetrievedUrl { get; init; }

    /// <summary>
    /// Status of the url retrieval.
    /// </summary>
    public UrlRetrievalStatus? UrlRetrievalStatus { get; init; }
}