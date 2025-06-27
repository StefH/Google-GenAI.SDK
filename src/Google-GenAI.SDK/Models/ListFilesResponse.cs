namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response for `ListFiles`.
/// </summary>
public class ListFilesResponse
{
    /// <summary>
    /// The list of `File`s.
    /// </summary>
    public IList<GoogleFile>? Files { get; init; }

    /// <summary>
    /// A token that can be sent as a `page_token` into a subsequent `ListFiles` call.
    /// </summary>
    public string? NextPageToken { get; init; }
}