namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
/// </summary>
public class Schema
{
    /// <summary>
    /// Optional. Minimum number of the properties for Type.OBJECT.
    /// </summary>
    public long? MinProperties { get; init; }

    /// <summary>
    /// Optional. Schema of the elements of Type.ARRAY.
    /// </summary>
    public Schema? Items { get; init; }

    /// <summary>
    /// Optional. The format of the data. This is used only for primitive datatypes. Supported formats:  for NUMBER type: float, double  for INTEGER type: int32, int64  for STRING type: enum, date-time
    /// </summary>
    public string? Format { get; init; }

    /// <summary>
    /// Required. Data type.
    /// </summary>
    public required SchemaType Type { get; init; }

    /// <summary>
    /// Optional. The title of the schema.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// Optional. SCHEMA FIELDS FOR TYPE STRING Minimum length of the Type.STRING
    /// </summary>
    public long? MinLength { get; init; }

    /// <summary>
    /// Optional. Default value of the field. Per JSON Schema, this field is intended for documentation generators and doesn't affect validation. Thus it's included here and ignored so that developers who send schemas with a `default` field don't get unknown-field errors.
    /// </summary>
    public object? Default { get; init; }

    /// <summary>
    /// Optional. A brief description of the parameter. This could contain examples of use. Parameter description may be formatted as Markdown.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Optional. The order of the properties. Not a standard field in open api spec. Used to determine the order of the properties in the response.
    /// </summary>
    public IList<string>? PropertyOrdering { get; init; }

    /// <summary>
    /// Optional. Maximum length of the Type.STRING
    /// </summary>
    public long? MaxLength { get; init; }

    /// <summary>
    /// Optional. Maximum number of the properties for Type.OBJECT.
    /// </summary>
    public long? MaxProperties { get; init; }

    /// <summary>
    /// Optional. Example of the object. Will only populated when the object is the root.
    /// </summary>
    public object? Example { get; init; }

    /// <summary>
    /// Optional. Indicates if the value may be null.
    /// </summary>
    public bool? Nullable { get; init; }

    /// <summary>
    /// Optional. Maximum value of the Type.INTEGER and Type.NUMBER
    /// </summary>
    public double? Maximum { get; init; }

    /// <summary>
    /// Optional. The value should be validated against any (one or more) of the subschemas in the list.
    /// </summary>
    public IList<Schema>? AnyOf { get; init; }

    /// <summary>
    /// Optional. Required properties of Type.OBJECT.
    /// </summary>
    public IList<string>? Required { get; init; }

    /// <summary>
    /// Optional. Minimum number of the elements for Type.ARRAY.
    /// </summary>
    public long? MinItems { get; init; }

    /// <summary>
    /// Optional. SCHEMA FIELDS FOR TYPE INTEGER and NUMBER Minimum value of the Type.INTEGER and Type.NUMBER
    /// </summary>
    public double? Minimum { get; init; }

    /// <summary>
    /// Optional. Properties of Type.OBJECT.
    /// </summary>
    public IDictionary<string, Schema>? Properties { get; init; }

    /// <summary>
    /// Optional. Maximum number of the elements for Type.ARRAY.
    /// </summary>
    public long? MaxItems { get; init; }

    /// <summary>
    /// Optional. Pattern of the Type.STRING to restrict a string to a regular expression.
    /// </summary>
    public string? Pattern { get; init; }

    /// <summary>
    /// Optional. Possible values of the element of Type.STRING with enum format. For example we can define an Enum Direction as : {type:STRING, format:enum, enum:["EAST", NORTH", "SOUTH", "WEST"]}
    /// </summary>
    public IList<string>? Enum { get; init; }
}