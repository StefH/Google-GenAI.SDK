﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. The role granted by this permission.
/// </summary>
public enum Role
{
    /// <summary>
    /// The default value. This value is unused.
    /// </summary>
    ROLE_UNSPECIFIED,

    /// <summary>
    /// Owner can use, update, share and delete the resource.
    /// </summary>
    OWNER,

    /// <summary>
    /// Writer can use, update and share the resource.
    /// </summary>
    WRITER,

    /// <summary>
    /// Reader can use the resource.
    /// </summary>
    READER,
}