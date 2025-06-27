namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. Operator applied to the given key-value pair to trigger the condition.
/// </summary>
public enum ConditionOperation
{
    /// <summary>
    /// The default value. This value is unused.
    /// </summary>
    OPERATOR_UNSPECIFIED,

    /// <summary>
    /// Supported by numeric.
    /// </summary>
    LESS,

    /// <summary>
    /// Supported by numeric.
    /// </summary>
    LESS_EQUAL,

    /// <summary>
    /// Supported by numeric & string.
    /// </summary>
    EQUAL,

    /// <summary>
    /// Supported by numeric.
    /// </summary>
    GREATER_EQUAL,

    /// <summary>
    /// Supported by numeric.
    /// </summary>
    GREATER,

    /// <summary>
    /// Supported by numeric & string.
    /// </summary>
    NOT_EQUAL,

    /// <summary>
    /// Supported by string only when `CustomMetadata` value type for the given key has a `string_list_value`.
    /// </summary>
    INCLUDES,

    /// <summary>
    /// Supported by string only when `CustomMetadata` value type for the given key has a `string_list_value`.
    /// </summary>
    EXCLUDES,
}