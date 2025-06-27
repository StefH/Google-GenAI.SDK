namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to generate a message response from the model.
/// </summary>
public class GenerateMessageRequest
{
    /// <summary>
    /// Optional. The maximum cumulative probability of tokens to consider when sampling.  The model uses combined Top-k and nucleus sampling.  Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`.
    /// </summary>
    public float? TopP { get; init; }

    /// <summary>
    /// Optional. Controls the randomness of the output.  Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model.
    /// </summary>
    public float? Temperature { get; init; }

    /// <summary>
    /// Required. The structured textual input given to the model as a prompt.  Given a prompt, the model will return what it predicts is the next message in the discussion.
    /// </summary>
    public required MessagePrompt Prompt { get; init; }

    /// <summary>
    /// Optional. The number of generated response messages to return.  This value must be between `[1, 8]`, inclusive. If unset, this will default to `1`.
    /// </summary>
    public int? CandidateCount { get; init; }

    /// <summary>
    /// Optional. The maximum number of tokens to consider when sampling.  The model uses combined Top-k and nucleus sampling.  Top-k sampling considers the set of `top_k` most probable tokens.
    /// </summary>
    public int? TopK { get; init; }
}