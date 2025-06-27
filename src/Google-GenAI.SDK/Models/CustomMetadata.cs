namespace GoogleGenAI.SDK.Models;

/// <summary>
/// User provided metadata stored as key-value pairs.
/// </summary>
public class CustomMetadata
{
    /// <summary>
    /// Required. The key of the metadata to store.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// The StringList value of the metadata to store.
    /// </summary>
    public StringList? StringListValue { get; init; }

    /// <summary>
    /// The string value of the metadata to store.
    /// </summary>
    public string? StringValue { get; init; }

    /// <summary>
    /// The numeric value of the metadata to store.
    /// </summary>
    public float? NumericValue { get; init; }
}