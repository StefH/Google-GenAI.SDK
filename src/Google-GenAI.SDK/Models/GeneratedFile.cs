namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A file generated on behalf of a user.
/// </summary>
public class GeneratedFile
{
    /// <summary>
    /// Error details if the GeneratedFile ends up in the STATE_FAILED state.
    /// </summary>
    public Status? Error { get; init; }

    /// <summary>
    /// Output only. The state of the GeneratedFile.
    /// </summary>
    public GeneratedFileState? State { get; init; }

    /// <summary>
    /// Identifier. The name of the generated file. Example: `generatedFiles/abc-123`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// MIME type of the generatedFile.
    /// </summary>
    public string? MimeType { get; init; }
}