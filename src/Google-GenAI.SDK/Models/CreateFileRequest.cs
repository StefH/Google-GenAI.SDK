namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request for `CreateFile`.
/// </summary>
public class CreateFileRequest
{
    /// <summary>
    /// Optional. Metadata for the file to create.
    /// </summary>
    public GoogleFile? File { get; init; }
}