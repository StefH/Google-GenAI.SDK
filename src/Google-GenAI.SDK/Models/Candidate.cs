namespace GoogleGenAI.SDK.Models;

/// <summary>
/// A response candidate generated from the model.
/// </summary>
public class Candidate
{
    /// <summary>
    /// List of ratings for the safety of a response candidate.  There is at most one rating per category.
    /// </summary>
    public IList<SafetyRating>? SafetyRatings { get; init; }

    /// <summary>
    /// Optional. Output only. The reason why the model stopped generating tokens.  If empty, the model has not stopped generating tokens.
    /// </summary>
    public FinishReason? FinishReason { get; init; }

    /// <summary>
    /// Output only. Generated content returned from the model.
    /// </summary>
    public Content? Content { get; init; }

    /// <summary>
    /// Output only. Log-likelihood scores for the response tokens and top tokens
    /// </summary>
    public LogprobsResult? LogprobsResult { get; init; }

    /// <summary>
    /// Output only. Attribution information for sources that contributed to a grounded answer.  This field is populated for `GenerateAnswer` calls.
    /// </summary>
    public IList<GroundingAttribution>? GroundingAttributions { get; init; }

    /// <summary>
    /// Output only. Index of the candidate in the list of response candidates.
    /// </summary>
    public int? Index { get; init; }

    /// <summary>
    /// Output only. Citation information for model-generated candidate.  This field may be populated with recitation information for any text included in the `content`. These are passages that are "recited" from copyrighted material in the foundational LLM's training data.
    /// </summary>
    public CitationMetadata? CitationMetadata { get; init; }

    /// <summary>
    /// Output only. Grounding metadata for the candidate.  This field is populated for `GenerateContent` calls.
    /// </summary>
    public GroundingMetadata? GroundingMetadata { get; init; }

    /// <summary>
    /// Output only. Token count for this candidate.
    /// </summary>
    public int? TokenCount { get; init; }

    /// <summary>
    /// Output only. Metadata related to url context retrieval tool.
    /// </summary>
    public UrlContextMetadata? UrlContextMetadata { get; init; }

    /// <summary>
    /// Output only. Average log probability score of the candidate.
    /// </summary>
    public double? AvgLogprobs { get; init; }
}