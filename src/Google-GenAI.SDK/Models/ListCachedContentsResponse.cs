namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response with CachedContents list.
/// </summary>
public class ListCachedContentsResponse
{
    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no subsequent pages.
    /// </summary>
    public string? NextPageToken { get; init; }

    /// <summary>
    /// List of cached contents.
    /// </summary>
    public IList<CachedContent>? CachedContents { get; init; }
}