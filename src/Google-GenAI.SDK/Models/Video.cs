namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Representation of a video.
/// </summary>
public class Video
{
    /// <summary>
    /// Raw bytes.
    /// </summary>
    public string? VideoData { get; init; }

    /// <summary>
    /// Path to another storage.
    /// </summary>
    public string? Uri { get; init; }
}