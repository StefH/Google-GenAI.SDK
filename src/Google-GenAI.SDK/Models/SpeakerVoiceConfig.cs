namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The configuration for a single speaker in a multi speaker setup.
/// </summary>
public class SpeakerVoiceConfig
{
    /// <summary>
    /// Required. The name of the speaker to use. Should be the same as in the prompt.
    /// </summary>
    public required string Speaker { get; init; }

    /// <summary>
    /// Required. The configuration for the voice to use.
    /// </summary>
    public required VoiceConfig VoiceConfig { get; init; }
}