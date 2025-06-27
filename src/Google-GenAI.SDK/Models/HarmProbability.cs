namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. The probability of harm for this content.
/// </summary>
public enum HarmProbability
{
    /// <summary>
    /// Probability is unspecified.
    /// </summary>
    HARM_PROBABILITY_UNSPECIFIED,

    /// <summary>
    /// Content has a negligible chance of being unsafe.
    /// </summary>
    NEGLIGIBLE,

    /// <summary>
    /// Content has a low chance of being unsafe.
    /// </summary>
    LOW,

    /// <summary>
    /// Content has a medium chance of being unsafe.
    /// </summary>
    MEDIUM,

    /// <summary>
    /// Content has a high chance of being unsafe.
    /// </summary>
    HIGH,
}