namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. The requested modalities of the response. Represents the set of modalities that the model can return, and should be expected in the response. This is an exact match to the modalities of the response. A model may have multiple combinations of supported modalities. If the requested modalities do not match any of the supported combinations, an error will be returned. An empty list is equivalent to requesting only text.
/// </summary>
public enum GenerationConfigResponseModalities
{
    /// <summary>
    /// Default value.
    /// </summary>
    MODALITY_UNSPECIFIED,

    /// <summary>
    /// Indicates the model should return text.
    /// </summary>
    TEXT,

    /// <summary>
    /// Indicates the model should return images.
    /// </summary>
    IMAGE,

    /// <summary>
    /// Indicates the model should return audio.
    /// </summary>
    AUDIO,
}