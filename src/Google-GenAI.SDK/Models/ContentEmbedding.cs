namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A list of floats representing an embedding.
/// </summary>
public class ContentEmbedding
{
    /// <summary>
    /// The embedding values.
    /// </summary>
    public IList<float>? Values { get; init; }
}