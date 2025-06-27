namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `ListCorpora` containing a paginated list of `Corpora`. The results are sorted by ascending `corpus.create_time`.
/// </summary>
public class ListCorporaResponse
{
    /// <summary>
    /// The returned corpora.
    /// </summary>
    public IList<Corpus>? Corpora { get; init; }

    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
    /// </summary>
    public string? NextPageToken { get; init; }
}