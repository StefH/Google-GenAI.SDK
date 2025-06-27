namespace GoogleGenAI.SDK.Models;

/// <summary>
/// User provided filter to limit retrieval based on `Chunk` or `Document` level metadata values. Example (genre = drama OR genre = action):   key = "document.custom_metadata.genre"   conditions = [{string_value = "drama", operation = EQUAL},                 {string_value = "action", operation = EQUAL}]
/// </summary>
public class MetadataFilter
{
    /// <summary>
    /// Required. The `Condition`s for the given key that will trigger this filter. Multiple `Condition`s are joined by logical ORs.
    /// </summary>
    public required IList<Condition> Conditions { get; init; }

    /// <summary>
    /// Required. The key of the metadata to filter on.
    /// </summary>
    public required string Key { get; init; }
}