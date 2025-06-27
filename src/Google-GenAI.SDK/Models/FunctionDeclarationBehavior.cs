namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
/// </summary>
public enum FunctionDeclarationBehavior
{
    /// <summary>
    /// This value is unused.
    /// </summary>
    UNSPECIFIED,

    /// <summary>
    /// If set, the system will wait to receive the function response before continuing the conversation.
    /// </summary>
    BLOCKING,

    /// <summary>
    /// If set, the system will not wait to receive the function response. Instead, it will attempt to handle function responses as they become available while maintaining the conversation between the user and the model.
    /// </summary>
    NON_BLOCKING,
}