namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
/// </summary>
public class PromptFeedback
{
    /// <summary>
    /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase the prompt.
    /// </summary>
    public BlockReason? BlockReason { get; init; }

    /// <summary>
    /// Ratings for safety of the prompt. There is at most one rating per category.
    /// </summary>
    public IList<SafetyRating>? SafetyRatings { get; init; }
}