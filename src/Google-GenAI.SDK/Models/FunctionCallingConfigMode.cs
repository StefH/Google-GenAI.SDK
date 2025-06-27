namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Optional. Specifies the mode in which function calling should execute. If unspecified, the default value will be set to AUTO.
/// </summary>
public enum FunctionCallingConfigMode
{
    /// <summary>
    /// Unspecified function calling mode. This value should not be used.
    /// </summary>
    MODE_UNSPECIFIED,

    /// <summary>
    /// Default model behavior, model decides to predict either a function call or a natural language response.
    /// </summary>
    AUTO,

    /// <summary>
    /// Model is constrained to always predicting a function call only. If "allowed_function_names" are set, the predicted function call will be limited to any one of "allowed_function_names", else the predicted function call will be any one of the provided "function_declarations".
    /// </summary>
    ANY,

    /// <summary>
    /// Model will not predict any function call. Model behavior is same as when not passing any function declarations.
    /// </summary>
    NONE,

    /// <summary>
    /// Model decides to predict either a function call or a natural language response, but will validate function calls with constrained decoding.
    /// </summary>
    VALIDATED,
}