namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to generate a grounded answer from the `Model`.
/// </summary>
public class GenerateAnswerRequest
{
    /// <summary>
    /// Passages provided inline with the request.
    /// </summary>
    public GroundingPassages? InlinePassages { get; init; }

    /// <summary>
    /// Optional. Controls the randomness of the output.  Values can range from [0.0,1.0], inclusive. A value closer to 1.0 will produce responses that are more varied and creative, while a value closer to 0.0 will typically result in more straightforward responses from the model. A low temperature (~0.2) is usually recommended for Attributed-Question-Answering use cases.
    /// </summary>
    public float? Temperature { get; init; }

    /// <summary>
    /// Content retrieved from resources created via the Semantic Retriever API.
    /// </summary>
    public SemanticRetrieverConfig? SemanticRetriever { get; init; }

    /// <summary>
    /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content.  This will be enforced on the `GenerateAnswerRequest.contents` and `GenerateAnswerResponse.candidate`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
    /// </summary>
    public IList<SafetySetting>? SafetySettings { get; init; }

    /// <summary>
    /// Required. Style in which answers should be returned.
    /// </summary>
    public required AnswerStyle AnswerStyle { get; init; }

    /// <summary>
    /// Required. The content of the current conversation with the `Model`. For single-turn queries, this is a single question to answer. For multi-turn queries, this is a repeated field that contains conversation history and the last `Content` in the list containing the question.  Note: `GenerateAnswer` only supports queries in English.
    /// </summary>
    public required IList<Content> Contents { get; init; }
}