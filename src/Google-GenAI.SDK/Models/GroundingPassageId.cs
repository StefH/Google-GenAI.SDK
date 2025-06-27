namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Identifier for a part within a `GroundingPassage`.
/// </summary>
public class GroundingPassageId
{
    /// <summary>
    /// Output only. ID of the passage matching the `GenerateAnswerRequest`'s `GroundingPassage.id`.
    /// </summary>
    public string? PassageId { get; init; }

    /// <summary>
    /// Output only. Index of the part within the `GenerateAnswerRequest`'s `GroundingPassage.content`.
    /// </summary>
    public int? PartIndex { get; init; }
}