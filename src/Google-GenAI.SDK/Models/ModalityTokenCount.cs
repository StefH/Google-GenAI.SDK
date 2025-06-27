namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Represents token counting info for a single modality.
/// </summary>
public class ModalityTokenCount
{
    /// <summary>
    /// The modality associated with this token count.
    /// </summary>
    public Modality? Modality { get; init; }

    /// <summary>
    /// Number of tokens.
    /// </summary>
    public int? TokenCount { get; init; }
}