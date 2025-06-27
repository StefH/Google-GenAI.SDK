namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Metadata related to url context retrieval tool.
/// </summary>
public class UrlContextMetadata
{
    /// <summary>
    /// List of url context.
    /// </summary>
    public IList<UrlMetadata>? UrlMetadata { get; init; }
}