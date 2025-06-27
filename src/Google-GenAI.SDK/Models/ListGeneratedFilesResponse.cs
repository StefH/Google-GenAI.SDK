namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response for `ListGeneratedFiles`.
/// </summary>
public class ListGeneratedFilesResponse
{
    /// <summary>
    /// A token that can be sent as a `page_token` into a subsequent `ListGeneratedFiles` call.
    /// </summary>
    public string? NextPageToken { get; init; }

    /// <summary>
    /// The list of `GeneratedFile`s.
    /// </summary>
    public IList<GeneratedFile>? GeneratedFiles { get; init; }
}