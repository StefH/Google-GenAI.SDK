namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response message for [PredictionService.PredictLongRunning]
/// </summary>
public class PredictLongRunningResponse
{
    /// <summary>
    /// The response of the video generation prediction.
    /// </summary>
    public GenerateVideoResponse? GenerateVideoResponse { get; init; }
}