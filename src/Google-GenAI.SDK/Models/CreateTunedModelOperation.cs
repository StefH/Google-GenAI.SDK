namespace GoogleGenAI.SDK.Models;

/// <summary>
/// This resource represents a long-running operation where metadata and response fields are strongly typed.
/// </summary>
public class CreateTunedModelOperation : BaseOperation
{
    public CreateTunedModelMetadata? Metadata { get; init; }

    public TunedModel? Response { get; init; }
}