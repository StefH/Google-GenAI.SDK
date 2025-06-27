namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. Immutable. The type of the grantee.
/// </summary>
public enum GranteeType
{
    /// <summary>
    /// The default value. This value is unused.
    /// </summary>
    GRANTEE_TYPE_UNSPECIFIED,

    /// <summary>
    /// Represents a user. When set, you must provide email_address for the user.
    /// </summary>
    USER,

    /// <summary>
    /// Represents a group. When set, you must provide email_address for the group.
    /// </summary>
    GROUP,

    /// <summary>
    /// Represents access to everyone. No extra information is required.
    /// </summary>
    EVERYONE,
}