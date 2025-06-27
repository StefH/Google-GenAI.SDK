namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `ListPermissions` containing a paginated list of permissions.
/// </summary>
public class ListPermissionsResponse
{
    /// <summary>
    /// Returned permissions.
    /// </summary>
    public IList<Permission>? Permissions { get; init; }

    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page.  If this field is omitted, there are no more pages.
    /// </summary>
    public string? NextPageToken { get; init; }
}