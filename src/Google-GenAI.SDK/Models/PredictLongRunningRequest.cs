namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Request message for [PredictionService.PredictLongRunning].
/// </summary>
public class PredictLongRunningRequest
{
    /// <summary>
    /// Optional. The parameters that govern the prediction call.
    /// </summary>
    public object? Parameters { get; init; }

    /// <summary>
    /// Required. The instances that are the input to the prediction call.
    /// </summary>
    public required IList<object> Instances { get; init; }
}