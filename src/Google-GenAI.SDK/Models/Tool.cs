namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Tool details that the model may use to generate response.  A `Tool` is a piece of code that enables the system to interact with external systems to perform an action, or set of actions, outside of knowledge and scope of the model.
/// </summary>
public class Tool
{
    /// <summary>
    /// Optional. GoogleSearch tool type. Tool to support Google Search in Model. Powered by Google.
    /// </summary>
    public GoogleSearch? GoogleSearch { get; init; }

    /// <summary>
    /// Optional. Tool to support URL context retrieval.
    /// </summary>
    public UrlContext? UrlContext { get; init; }

    /// <summary>
    /// Optional. Enables the model to execute code as part of generation.
    /// </summary>
    public CodeExecution? CodeExecution { get; init; }

    /// <summary>
    /// Optional. A list of `FunctionDeclarations` available to the model that can be used for function calling.  The model or system does not execute the function. Instead the defined function may be returned as a FunctionCall with arguments to the client side for execution. The model may decide to call a subset of these functions by populating FunctionCall in the response. The next conversation turn may contain a FunctionResponse with the Content.role "function" generation context for the next model turn.
    /// </summary>
    public IList<FunctionDeclaration>? FunctionDeclarations { get; init; }

    /// <summary>
    /// Optional. Retrieval tool that is powered by Google search.
    /// </summary>
    public GoogleSearchRetrieval? GoogleSearchRetrieval { get; init; }
}