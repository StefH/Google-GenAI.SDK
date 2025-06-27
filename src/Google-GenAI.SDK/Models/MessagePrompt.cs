﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// All of the structured input text passed to the model as a prompt.  A `MessagePrompt` contains a structured set of fields that provide context for the conversation, examples of user input/model output message pairs that prime the model to respond in different ways, and the conversation history or list of messages representing the alternating turns of the conversation between the user and the model.
/// </summary>
public class MessagePrompt
{
    /// <summary>
    /// Optional. Examples of what the model should generate.  This includes both user input and the response that the model should emulate.  These `examples` are treated identically to conversation messages except that they take precedence over the history in `messages`: If the total input size exceeds the model's `input_token_limit` the input will be truncated. Items will be dropped from `messages` before `examples`.
    /// </summary>
    public IList<Example>? Examples { get; init; }

    /// <summary>
    /// Optional. Text that should be provided to the model first to ground the response.  If not empty, this `context` will be given to the model first before the `examples` and `messages`. When using a `context` be sure to provide it with every request to maintain continuity.  This field can be a description of your prompt to the model to help provide context and guide the responses. Examples: "Translate the phrase from English to French." or "Given a statement, classify the sentiment as happy, sad or neutral."  Anything included in this field will take precedence over message history if the total input size exceeds the model's `input_token_limit` and the input request is truncated.
    /// </summary>
    public string? Context { get; init; }

    /// <summary>
    /// Required. A snapshot of the recent conversation history sorted chronologically.  Turns alternate between two authors.  If the total input size exceeds the model's `input_token_limit` the input will be truncated: The oldest items will be dropped from `messages`.
    /// </summary>
    public required IList<Message> Messages { get; init; }
}