namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Google search entry point.
/// </summary>
public class SearchEntryPoint
{
    /// <summary>
    /// Optional. Web content snippet that can be embedded in a web page or an app webview.
    /// </summary>
    public string? RenderedContent { get; init; }

    /// <summary>
    /// Optional. Base64 encoded JSON representing array of  tuple.
    /// </summary>
    public string? SdkBlob { get; init; }
}