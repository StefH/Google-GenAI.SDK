namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. If specified, the media resolution specified will be used.
/// </summary>
public enum MediaResolution
{
    /// <summary>
    /// Media resolution has not been set.
    /// </summary>
    MEDIA_RESOLUTION_UNSPECIFIED,

    /// <summary>
    /// Media resolution set to low (64 tokens).
    /// </summary>
    MEDIA_RESOLUTION_LOW,

    /// <summary>
    /// Media resolution set to medium (256 tokens).
    /// </summary>
    MEDIA_RESOLUTION_MEDIUM,

    /// <summary>
    /// Media resolution set to high (zoomed reframing with 256 tokens).
    /// </summary>
    MEDIA_RESOLUTION_HIGH,
}