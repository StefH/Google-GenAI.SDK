namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Output only. Processing state of the File.
/// </summary>
public enum FileState
{
    /// <summary>
    /// The default value. This value is used if the state is omitted.
    /// </summary>
    STATE_UNSPECIFIED,

    /// <summary>
    /// File is being processed and cannot be used for inference yet.
    /// </summary>
    PROCESSING,

    /// <summary>
    /// File is processed and available for inference.
    /// </summary>
    ACTIVE,

    /// <summary>
    /// File failed processing.
    /// </summary>
    FAILED,
}