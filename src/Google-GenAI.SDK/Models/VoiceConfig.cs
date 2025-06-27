namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The configuration for the voice to use.
/// </summary>
public class VoiceConfig
{
    /// <summary>
    /// The configuration for the prebuilt voice to use.
    /// </summary>
    public PrebuiltVoiceConfig? PrebuiltVoiceConfig { get; init; }
}