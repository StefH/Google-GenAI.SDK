﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Grounding support.
/// </summary>
public class GroundingSupport
{
    /// <summary>
    /// Confidence score of the support references. Ranges from 0 to 1. 1 is the most confident. This list must have the same size as the grounding_chunk_indices.
    /// </summary>
    public IList<float>? ConfidenceScores { get; init; }

    /// <summary>
    /// A list of indices (into 'grounding_chunk') specifying the citations associated with the claim. For instance [1,3,4] means that grounding_chunk[1], grounding_chunk[3], grounding_chunk[4] are the retrieved content attributed to the claim.
    /// </summary>
    public IList<int>? GroundingChunkIndices { get; init; }

    /// <summary>
    /// Segment of the content this support belongs to.
    /// </summary>
    public Segment? Segment { get; init; }
}