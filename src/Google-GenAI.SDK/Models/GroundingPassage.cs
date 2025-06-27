namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Passage included inline with a grounding configuration.
/// </summary>
public class GroundingPassage
{
    /// <summary>
    /// Content of the passage.
    /// </summary>
    public Content? Content { get; init; }

    /// <summary>
    /// Identifier for the passage for attributing this passage in grounded answers.
    /// </summary>
    public string? Id { get; init; }
}