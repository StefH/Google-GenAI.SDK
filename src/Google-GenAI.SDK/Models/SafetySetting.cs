namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Safety setting, affecting the safety-blocking behavior.  Passing a safety setting for a category changes the allowed probability that content is blocked.
/// </summary>
public class SafetySetting
{
    /// <summary>
    /// Required. Controls the probability threshold at which harm is blocked.
    /// </summary>
    public required HarmBlockThreshold Threshold { get; init; }

    /// <summary>
    /// Required. The category for this setting.
    /// </summary>
    public required HarmCategory Category { get; init; }
}