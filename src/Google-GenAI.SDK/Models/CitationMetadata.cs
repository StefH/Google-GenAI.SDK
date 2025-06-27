namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A collection of source attributions for a piece of content.
/// </summary>
public class CitationMetadata
{
    /// <summary>
    /// Citations to sources for a specific response.
    /// </summary>
    public IList<CitationSource>? CitationSources { get; init; }
}