namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Output only. The state of the tuned model.
/// </summary>
public enum TunedModelState
{
    /// <summary>
    /// The default value. This value is unused.
    /// </summary>
    STATE_UNSPECIFIED,

    /// <summary>
    /// The model is being created.
    /// </summary>
    CREATING,

    /// <summary>
    /// The model is ready to be used.
    /// </summary>
    ACTIVE,

    /// <summary>
    /// The model failed to be created.
    /// </summary>
    FAILED,
}