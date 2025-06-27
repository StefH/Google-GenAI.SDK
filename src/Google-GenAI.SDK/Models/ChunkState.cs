namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Output only. Current state of the `Chunk`.
/// </summary>
public enum ChunkState
{
    /// <summary>
    /// The default value. This value is used if the state is omitted.
    /// </summary>
    STATE_UNSPECIFIED,

    /// <summary>
    /// `Chunk` is being processed (embedding and vector storage).
    /// </summary>
    STATE_PENDING_PROCESSING,

    /// <summary>
    /// `Chunk` is processed and available for querying.
    /// </summary>
    STATE_ACTIVE,

    /// <summary>
    /// `Chunk` failed processing.
    /// </summary>
    STATE_FAILED,
}