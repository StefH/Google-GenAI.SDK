namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Chunk from the web.
/// </summary>
public class Web
{
    /// <summary>
    /// Title of the chunk.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// URI reference of the chunk.
    /// </summary>
    public string? Uri { get; init; }
}