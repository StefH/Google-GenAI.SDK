namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Status of the url retrieval.
/// </summary>
public enum UrlRetrievalStatus
{
    /// <summary>
    /// Default value. This value is unused.
    /// </summary>
    URL_RETRIEVAL_STATUS_UNSPECIFIED,

    /// <summary>
    /// Url retrieval is successful.
    /// </summary>
    URL_RETRIEVAL_STATUS_SUCCESS,

    /// <summary>
    /// Url retrieval is failed due to error.
    /// </summary>
    URL_RETRIEVAL_STATUS_ERROR,
}