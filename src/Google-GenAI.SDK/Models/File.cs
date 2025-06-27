namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A file uploaded to the API. Next ID: 15
/// </summary>
public class GoogleFile
{
    /// <summary>
    /// Output only. Processing state of the File.
    /// </summary>
    public FileState? State { get; init; }

    /// <summary>
    /// Output only. The timestamp of when the `File` will be deleted. Only set if the `File` is scheduled to expire.
    /// </summary>
    public System.DateTime? ExpirationTime { get; init; }

    /// <summary>
    /// Optional. The human-readable display name for the `File`. The display name must be no more than 512 characters in length, including spaces. Example: "Welcome Image"
    /// </summary>
    public string? DisplayName { get; init; }

    /// <summary>
    /// Output only. The timestamp of when the `File` was created.
    /// </summary>
    public System.DateTime? CreateTime { get; init; }

    /// <summary>
    /// Output only. SHA-256 hash of the uploaded bytes.
    /// </summary>
    public string? Sha256Hash { get; init; }

    /// <summary>
    /// Output only. The download uri of the `File`.
    /// </summary>
    public string? DownloadUri { get; init; }

    /// <summary>
    /// Output only. Size of the file in bytes.
    /// </summary>
    public long? SizeBytes { get; init; }

    /// <summary>
    /// Output only. Error status if File processing failed.
    /// </summary>
    public Status? Error { get; init; }

    /// <summary>
    /// Output only. Metadata for a video.
    /// </summary>
    public VideoFileMetadata? VideoMetadata { get; init; }

    /// <summary>
    /// Output only. The uri of the `File`.
    /// </summary>
    public string? Uri { get; init; }

    /// <summary>
    /// Source of the File.
    /// </summary>
    public FileSource? Source { get; init; }

    /// <summary>
    /// Output only. MIME type of the file.
    /// </summary>
    public string? MimeType { get; init; }

    /// <summary>
    /// Immutable. Identifier. The `File` resource name. The ID (name excluding the "files/" prefix) can contain up to 40 characters that are lowercase alphanumeric or dashes (-). The ID cannot start or end with a dash. If the name is empty on create, a unique name will be generated. Example: `files/123-456`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Output only. The timestamp of when the `File` was last updated.
    /// </summary>
    public System.DateTime? UpdateTime { get; init; }
}