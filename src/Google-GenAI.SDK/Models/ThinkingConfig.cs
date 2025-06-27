namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Config for thinking features.
/// </summary>
public class ThinkingConfig
{
    /// <summary>
    /// The number of thoughts tokens that the model should generate.
    /// </summary>
    public int? ThinkingBudget { get; init; }

    /// <summary>
    /// Indicates whether to include thoughts in the response. If true, thoughts are returned only when available.
    /// </summary>
    public bool? IncludeThoughts { get; init; }
}