namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response for `CreateFile`.
/// </summary>
public class CreateFileResponse
{
    /// <summary>
    /// Metadata for the created file.
    /// </summary>
    public GoogleFile? File { get; init; }
}