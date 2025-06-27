namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The configuration for the multi-speaker setup.
/// </summary>
public class MultiSpeakerVoiceConfig
{
    /// <summary>
    /// Required. All the enabled speaker voices.
    /// </summary>
    public required IList<SpeakerVoiceConfig> SpeakerVoiceConfigs { get; init; }
}