namespace GoogleGenAI.SDK.Models;

/// <summary>
/// User provided string values assigned to a single metadata key.
/// </summary>
public class StringList
{
    /// <summary>
    /// The string values of the metadata to store.
    /// </summary>
    public IList<string>? Values { get; init; }
}