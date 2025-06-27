namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A list of floats representing the embedding.
/// </summary>
public class Embedding
{
    /// <summary>
    /// The embedding values.
    /// </summary>
    public IList<float>? Value { get; init; }
}