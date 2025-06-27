﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Metadata describes the input video content.
/// </summary>
public class VideoMetadata
{
    /// <summary>
    /// Optional. The end offset of the video.
    /// </summary>
    public string? EndOffset { get; init; }

    /// <summary>
    /// Optional. The start offset of the video.
    /// </summary>
    public string? StartOffset { get; init; }

    /// <summary>
    /// Optional. The frame rate of the video sent to the model. If not specified, the default value will be 1.0. The fps range is (0.0, 24.0].
    /// </summary>
    public double? Fps { get; init; }
}