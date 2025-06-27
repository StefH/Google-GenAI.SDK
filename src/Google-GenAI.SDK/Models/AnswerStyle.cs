namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. Style in which answers should be returned.
/// </summary>
public enum AnswerStyle
{
    /// <summary>
    /// Unspecified answer style.
    /// </summary>
    ANSWER_STYLE_UNSPECIFIED,

    /// <summary>
    /// Succint but abstract style.
    /// </summary>
    ABSTRACTIVE,

    /// <summary>
    /// Very brief and extractive style.
    /// </summary>
    EXTRACTIVE,

    /// <summary>
    /// Verbose style including extra details. The response may be formatted as a sentence, paragraph, multiple paragraphs, or bullet points, etc.
    /// </summary>
    VERBOSE,
}