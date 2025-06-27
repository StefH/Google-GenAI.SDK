namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `ListDocuments` containing a paginated list of `Document`s. The `Document`s are sorted by ascending `document.create_time`.
/// </summary>
public class ListDocumentsResponse
{
    /// <summary>
    /// The returned `Document`s.
    /// </summary>
    public IList<Document>? Documents { get; init; }

    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
    /// </summary>
    public string? NextPageToken { get; init; }
}