namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Output only. The state of the GeneratedFile.
/// </summary>
public enum GeneratedFileState
{
    /// <summary>
    /// The default value. This value is used if the state is omitted.
    /// </summary>
    STATE_UNSPECIFIED,

    /// <summary>
    /// Being generated.
    /// </summary>
    GENERATING,

    /// <summary>
    /// Generated and is ready for download.
    /// </summary>
    GENERATED,

    /// <summary>
    /// Failed to generate the GeneratedFile.
    /// </summary>
    FAILED,
}