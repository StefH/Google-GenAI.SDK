namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response message for [PredictionService.Predict].
/// </summary>
public class PredictResponse
{
    /// <summary>
    /// The outputs of the prediction call.
    /// </summary>
    public IList<object>? Predictions { get; init; }
}