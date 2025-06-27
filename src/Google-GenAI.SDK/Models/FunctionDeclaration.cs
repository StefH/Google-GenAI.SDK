namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Structured representation of a function declaration as defined by the [OpenAPI 3.03 specification](https://spec.openapis.org/oas/v3.0.3). Included in this declaration are the function name and parameters. This FunctionDeclaration is a representation of a block of code that can be used as a `Tool` by the model and executed by the client.
/// </summary>
public class FunctionDeclaration
{
    /// <summary>
    /// Optional. Describes the parameters to the function in JSON Schema format. The schema must describe an object where the properties are the parameters to the function. For example:  ``` {   "type": "object",   "properties": {     "name": { "type": "string" },     "age": { "type": "integer" }   },   "additionalProperties": false,   "required": ["name", "age"],   "propertyOrdering": ["name", "age"] } ```  This field is mutually exclusive with `parameters`.
    /// </summary>
    public object? ParametersJsonSchema { get; init; }

    /// <summary>
    /// Optional. Describes the output from this function in JSON Schema format. Reflects the Open API 3.03 Response Object. The Schema defines the type used for the response value of the function.
    /// </summary>
    public Schema? Response { get; init; }

    /// <summary>
    /// Optional. Specifies the function Behavior. Currently only supported by the BidiGenerateContent method.
    /// </summary>
    public FunctionDeclarationBehavior? Behavior { get; init; }

    /// <summary>
    /// Required. A brief description of the function.
    /// </summary>
    public required string Description { get; init; }

    /// <summary>
    /// Required. The name of the function. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 63.
    /// </summary>
    public required string Name { get; init; }

    /// <summary>
    /// Optional. Describes the parameters to this function. Reflects the Open API 3.03 Parameter Object string Key: the name of the parameter. Parameter names are case sensitive. Schema Value: the Schema defining the type used for the parameter.
    /// </summary>
    public Schema? Parameters { get; init; }

    /// <summary>
    /// Optional. Describes the output from this function in JSON Schema format. The value specified by the schema is the response value of the function.  This field is mutually exclusive with `response`.
    /// </summary>
    public object? ResponseJsonSchema { get; init; }
}