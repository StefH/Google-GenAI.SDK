namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The base structured datatype containing multi-part content of a message.  A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
/// </summary>
public class Content
{
    /// <summary>
    /// Ordered `Parts` that constitute a single message. Parts may have different MIME types.
    /// </summary>
    public IList<Part>? Parts { get; init; }

    /// <summary>
    /// Optional. The producer of the content. Must be either 'user' or 'model'.  Useful to set for multi-turn conversations, otherwise can be left blank or unset.
    /// </summary>
    public string? Role { get; init; }
}