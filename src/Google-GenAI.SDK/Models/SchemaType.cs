namespace GoogleGenAI.SDK.Models;

public enum SchemaType
{
    /// <summary>
    /// Not specified, should not be used.
    /// </summary>
    TYPE_UNSPECIFIED,

    /// <summary>
    /// String type.
    /// </summary>
    STRING,

    /// <summary>
    /// Number type.
    /// </summary>
    NUMBER,

    /// <summary>
    /// Integer type.
    /// </summary>
    INTEGER,

    /// <summary>
    /// Boolean type.
    /// </summary>
    BOOLEAN,

    /// <summary>
    /// Array type.
    /// </summary>
    ARRAY,

    /// <summary>
    /// Object type.
    /// </summary>
    OBJECT,

    /// <summary>
    /// Null type.
    /// </summary>
    NULL,
}