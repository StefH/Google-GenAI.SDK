namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Response from the model supporting multiple candidate responses.  Safety ratings and content filtering are reported for both prompt in `GenerateContentResponse.prompt_feedback` and for each candidate in `finish_reason` and in `safety_ratings`. The API:  - Returns either all requested candidates or none of them  - Returns no candidates at all only if there was something wrong with the    prompt (check `prompt_feedback`)  - Reports feedback on each candidate in `finish_reason` and    `safety_ratings`.
/// </summary>
public class GenerateContentResponse
{
    /// <summary>
    /// Returns the prompt's feedback related to the content filters.
    /// </summary>
    public PromptFeedback? PromptFeedback { get; init; }

    /// <summary>
    /// Output only. The model version used to generate the response.
    /// </summary>
    public string? ModelVersion { get; init; }

    /// <summary>
    /// Output only. response_id is used to identify each response.
    /// </summary>
    public string? ResponseId { get; init; }

    /// <summary>
    /// Output only. Metadata on the generation requests' token usage.
    /// </summary>
    public UsageMetadata? UsageMetadata { get; init; }

    /// <summary>
    /// Candidate responses from the model.
    /// </summary>
    public IList<Candidate>? Candidates { get; init; }
}