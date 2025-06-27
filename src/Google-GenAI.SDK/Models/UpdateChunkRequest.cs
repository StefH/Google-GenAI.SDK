namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to update a `Chunk`.
/// </summary>
public class UpdateChunkRequest
{
    /// <summary>
    /// Required. The `Chunk` to update.
    /// </summary>
    public required Chunk Chunk { get; init; }

    /// <summary>
    /// Required. The list of fields to update. Currently, this only supports updating `custom_metadata` and `data`.
    /// </summary>
    public required string UpdateMask { get; init; }
}