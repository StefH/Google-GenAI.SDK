namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Safety rating for a piece of content.  The safety rating contains the category of harm and the harm probability level in that category for a piece of content. Content is classified for safety across a number of harm categories and the probability of the harm classification is included here.
/// </summary>
public class SafetyRating
{
    /// <summary>
    /// Required. The probability of harm for this content.
    /// </summary>
    public required HarmProbability Probability { get; init; }

    /// <summary>
    /// Required. The category for this rating.
    /// </summary>
    public required HarmCategory Category { get; init; }

    /// <summary>
    /// Was this content blocked because of this rating?
    /// </summary>
    public bool? Blocked { get; init; }
}