namespace GoogleGenAI.SDK.Models;

/// <summary>
/// URI based data.
/// </summary>
public class FileData
{
    /// <summary>
    /// Required. URI.
    /// </summary>
    public required string FileUri { get; init; }

    /// <summary>
    /// Optional. The IANA standard MIME type of the source data.
    /// </summary>
    public string? MimeType { get; init; }
}