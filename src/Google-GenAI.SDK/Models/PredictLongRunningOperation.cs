namespace GoogleGenAI.SDK.Models;

/// <summary>
/// This resource represents a long-running operation where metadata and response fields are strongly typed.
/// </summary>
public class PredictLongRunningOperation : BaseOperation
{
    public PredictLongRunningResponse? Response { get; init; }

    public PredictLongRunningMetadata? Metadata { get; init; }
}