namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. Controls the probability threshold at which harm is blocked.
/// </summary>
public enum HarmBlockThreshold
{
    /// <summary>
    /// Threshold is unspecified.
    /// </summary>
    HARM_BLOCK_THRESHOLD_UNSPECIFIED,

    /// <summary>
    /// Content with NEGLIGIBLE will be allowed.
    /// </summary>
    BLOCK_LOW_AND_ABOVE,

    /// <summary>
    /// Content with NEGLIGIBLE and LOW will be allowed.
    /// </summary>
    BLOCK_MEDIUM_AND_ABOVE,

    /// <summary>
    /// Content with NEGLIGIBLE, LOW, and MEDIUM will be allowed.
    /// </summary>
    BLOCK_ONLY_HIGH,

    /// <summary>
    /// All content will be allowed.
    /// </summary>
    BLOCK_NONE,

    /// <summary>
    /// Turn off the safety filter.
    /// </summary>
    OFF,
}