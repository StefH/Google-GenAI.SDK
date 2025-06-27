namespace GoogleGenAI.SDK.Models;

public enum TaskType
{
    /// <summary>
    /// Unset value, which will default to one of the other enum values.
    /// </summary>
    TASK_TYPE_UNSPECIFIED,

    /// <summary>
    /// Specifies the given text is a query in a search/retrieval setting.
    /// </summary>
    RETRIEVAL_QUERY,

    /// <summary>
    /// Specifies the given text is a document from the corpus being searched.
    /// </summary>
    RETRIEVAL_DOCUMENT,

    /// <summary>
    /// Specifies the given text will be used for STS.
    /// </summary>
    SEMANTIC_SIMILARITY,

    /// <summary>
    /// Specifies that the given text will be classified.
    /// </summary>
    CLASSIFICATION,

    /// <summary>
    /// Specifies that the embeddings will be used for clustering.
    /// </summary>
    CLUSTERING,

    /// <summary>
    /// Specifies that the given text will be used for question answering.
    /// </summary>
    QUESTION_ANSWERING,

    /// <summary>
    /// Specifies that the given text will be used for fact verification.
    /// </summary>
    FACT_VERIFICATION,

    /// <summary>
    /// Specifies that the given text will be used for code retrieval.
    /// </summary>
    CODE_RETRIEVAL_QUERY,
}