namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Filter condition applicable to a single key.
/// </summary>
public class Condition
{
    /// <summary>
    /// The string value to filter the metadata on.
    /// </summary>
    public string? StringValue { get; init; }

    /// <summary>
    /// The numeric value to filter the metadata on.
    /// </summary>
    public float? NumericValue { get; init; }

    /// <summary>
    /// Required. Operator applied to the given key-value pair to trigger the condition.
    /// </summary>
    public required ConditionOperation Operation { get; init; }
}