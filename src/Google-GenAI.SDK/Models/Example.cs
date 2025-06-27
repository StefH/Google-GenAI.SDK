namespace GoogleGenAI.SDK.Models;

/// <summary>
/// An input/output example used to instruct the Model.  It demonstrates how the model should respond or format its response.
/// </summary>
public class Example
{
    /// <summary>
    /// Required. An example of an input `Message` from the user.
    /// </summary>
    public required Message Input { get; init; }

    /// <summary>
    /// Required. An example of what the model should output given the input.
    /// </summary>
    public required Message Output { get; init; }
}