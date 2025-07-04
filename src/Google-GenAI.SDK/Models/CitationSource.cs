﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A citation to a source for a portion of a specific response.
/// </summary>
public class CitationSource
{
    /// <summary>
    /// Optional. Start of segment of the response that is attributed to this source.  Index indicates the start of the segment, measured in bytes.
    /// </summary>
    public int? StartIndex { get; init; }

    /// <summary>
    /// Optional. End of the attributed segment, exclusive.
    /// </summary>
    public int? EndIndex { get; init; }

    /// <summary>
    /// Optional. License for the GitHub project that is attributed as a source for segment.  License info is required for code citations.
    /// </summary>
    public string? License { get; init; }

    /// <summary>
    /// Optional. URI that is attributed as a source for a portion of the text.
    /// </summary>
    public string? Uri { get; init; }
}