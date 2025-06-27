namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `ListTunedModels` containing a paginated list of Models.
/// </summary>
public class ListTunedModelsResponse
{
    /// <summary>
    /// The returned Models.
    /// </summary>
    public IList<TunedModel>? TunedModels { get; init; }

    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page.  If this field is omitted, there are no more pages.
    /// </summary>
    public string? NextPageToken { get; init; }
}