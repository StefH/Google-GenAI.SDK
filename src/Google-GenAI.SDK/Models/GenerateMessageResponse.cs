namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The response from the model.  This includes candidate messages and conversation history in the form of chronologically-ordered messages.
/// </summary>
public class GenerateMessageResponse
{
    /// <summary>
    /// A set of content filtering metadata for the prompt and response text.  This indicates which `SafetyCategory`(s) blocked a candidate from this response, the lowest `HarmProbability` that triggered a block, and the HarmThreshold setting for that category.
    /// </summary>
    public IList<ContentFilter>? Filters { get; init; }

    /// <summary>
    /// Candidate response messages from the model.
    /// </summary>
    public IList<Message>? Candidates { get; init; }

    /// <summary>
    /// The conversation history used by the model.
    /// </summary>
    public IList<Message>? Messages { get; init; }
}