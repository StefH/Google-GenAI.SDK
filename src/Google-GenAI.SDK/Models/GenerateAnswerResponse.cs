namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from the model for a grounded answer.
/// </summary>
public class GenerateAnswerResponse
{
    /// <summary>
    /// Output only. Feedback related to the input data used to answer the question, as opposed to the model-generated response to the question.  The input data can be one or more of the following:  - Question specified by the last entry in `GenerateAnswerRequest.content` - Conversation history specified by the other entries in `GenerateAnswerRequest.content` - Grounding sources (`GenerateAnswerRequest.semantic_retriever` or `GenerateAnswerRequest.inline_passages`)
    /// </summary>
    public InputFeedback? InputFeedback { get; init; }

    /// <summary>
    /// Candidate answer from the model.  Note: The model *always* attempts to provide a grounded answer, even when the answer is unlikely to be answerable from the given passages. In that case, a low-quality or ungrounded answer may be provided, along with a low `answerable_probability`.
    /// </summary>
    public Candidate? Answer { get; init; }

    /// <summary>
    /// Output only. The model's estimate of the probability that its answer is correct and grounded in the input passages.  A low `answerable_probability` indicates that the answer might not be grounded in the sources.  When `answerable_probability` is low, you may want to:  * Display a message to the effect of "We couldn’t answer that question" to the user. * Fall back to a general-purpose LLM that answers the question from world knowledge. The threshold and nature of such fallbacks will depend on individual use cases. `0.5` is a good starting threshold.
    /// </summary>
    public float? AnswerableProbability { get; init; }
}