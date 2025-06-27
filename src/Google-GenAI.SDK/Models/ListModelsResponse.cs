namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `ListModel` containing a paginated list of Models.
/// </summary>
public class ListModelsResponse
{
    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page.  If this field is omitted, there are no more pages.
    /// </summary>
    public string? NextPageToken { get; init; }

    /// <summary>
    /// The returned Models.
    /// </summary>
    public IList<Model>? Models { get; init; }
}