﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request to generate a completion from the model. NEXT ID: 14
/// </summary>
public class GenerateContentRequest
{
    /// <summary>
    /// Optional. Developer set [system instruction(s)](https://ai.google.dev/gemini-api/docs/system-instructions). Currently, text only.
    /// </summary>
    public Content? SystemInstruction { get; init; }

    /// <summary>
    /// Required. The content of the current conversation with the model.  For single-turn queries, this is a single instance. For multi-turn queries like [chat](https://ai.google.dev/gemini-api/docs/text-generation#chat), this is a repeated field that contains the conversation history and the latest request.
    /// </summary>
    public required IList<Content> Contents { get; init; }

    /// <summary>
    /// Optional. Tool configuration for any `Tool` specified in the request. Refer to the [Function calling guide](https://ai.google.dev/gemini-api/docs/function-calling#function_calling_mode) for a usage example.
    /// </summary>
    public ToolConfig? ToolConfig { get; init; }

    /// <summary>
    /// Optional. Configuration options for model generation and outputs.
    /// </summary>
    public GenerationConfig? GenerationConfig { get; init; }

    /// <summary>
    /// Optional. A list of `Tools` the `Model` may use to generate the next response.  A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the `Model`. Supported `Tool`s are `Function` and `code_execution`. Refer to the [Function calling](https://ai.google.dev/gemini-api/docs/function-calling) and the [Code execution](https://ai.google.dev/gemini-api/docs/code-execution) guides to learn more.
    /// </summary>
    public IList<Tool>? Tools { get; init; }

    /// <summary>
    /// Optional. The name of the content [cached](https://ai.google.dev/gemini-api/docs/caching) to use as context to serve the prediction. Format: `cachedContents/{cachedContent}`
    /// </summary>
    public string? CachedContent { get; init; }

    /// <summary>
    /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content.  This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT, HARM_CATEGORY_CIVIC_INTEGRITY are supported. Refer to the [guide](https://ai.google.dev/gemini-api/docs/safety-settings) for detailed information on available safety settings. Also refer to the [Safety guidance](https://ai.google.dev/gemini-api/docs/safety-guidance) to learn how to incorporate safety considerations in your AI applications.
    /// </summary>
    public IList<SafetySetting>? SafetySettings { get; init; }
}