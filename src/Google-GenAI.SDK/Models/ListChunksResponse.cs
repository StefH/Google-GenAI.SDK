namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from `ListChunks` containing a paginated list of `Chunk`s. The `Chunk`s are sorted by ascending `chunk.create_time`.
/// </summary>
public class ListChunksResponse
{
    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
    /// </summary>
    public string? NextPageToken { get; init; }

    /// <summary>
    /// The returned `Chunk`s.
    /// </summary>
    public IList<Chunk>? Chunks { get; init; }
}