namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response from the model, including candidate completions.
/// </summary>
public class GenerateTextResponse
{
    /// <summary>
    /// Returns any safety feedback related to content filtering.
    /// </summary>
    public IList<SafetyFeedback>? SafetyFeedback { get; init; }

    /// <summary>
    /// Candidate responses from the model.
    /// </summary>
    public IList<TextCompletion>? Candidates { get; init; }

    /// <summary>
    /// A set of content filtering metadata for the prompt and response text.  This indicates which `SafetyCategory`(s) blocked a candidate from this response, the lowest `HarmProbability` that triggered a block, and the HarmThreshold setting for that category. This indicates the smallest change to the `SafetySettings` that would be necessary to unblock at least 1 response.  The blocking is configured by the `SafetySettings` in the request (or the default `SafetySettings` of the API).
    /// </summary>
    public IList<ContentFilter>? Filters { get; init; }
}