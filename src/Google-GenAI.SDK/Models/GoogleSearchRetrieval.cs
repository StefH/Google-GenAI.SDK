namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Tool to retrieve public web data for grounding, powered by Google.
/// </summary>
public class GoogleSearchRetrieval
{
    /// <summary>
    /// Specifies the dynamic retrieval configuration for the given source.
    /// </summary>
    public DynamicRetrievalMode? DynamicRetrievalConfig { get; init; }
}