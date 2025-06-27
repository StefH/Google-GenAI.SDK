namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A proto encapsulate various type of media.
/// </summary>
public class Media
{
    /// <summary>
    /// Video as the only one for now.  This is mimicking Vertex proto.
    /// </summary>
    public Video? Video { get; init; }
}