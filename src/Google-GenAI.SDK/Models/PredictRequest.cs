namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request message for PredictionService.Predict.
/// </summary>
public class PredictRequest
{
    /// <summary>
    /// Required. The instances that are the input to the prediction call.
    /// </summary>
    public required IList<object> Instances { get; init; }

    /// <summary>
    /// Optional. The parameters that govern the prediction call.
    /// </summary>
    public object? Parameters { get; init; }
}