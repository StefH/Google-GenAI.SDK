namespace GoogleGenAI.SDK.Models;

/// <summary>
/// The category of harm. These are the categories of harm that content is classified for.
/// </summary>
public enum HarmCategory
{
    /// <summary>
    /// Category is unspecified.
    /// </summary>
    HARM_CATEGORY_UNSPECIFIED,

    /// <summary>
    /// **PaLM** - Negative or harmful comments targeting identity and/or protected attribute.
    /// </summary>
    HARM_CATEGORY_DEROGATORY,

    /// <summary>
    /// **PaLM** - Content that is rude, disrespectful, or profane.
    /// </summary>
    HARM_CATEGORY_TOXICITY,

    /// <summary>
    /// **PaLM** - Describes scenarios depicting violence against an individual or group, or general descriptions of gore.
    /// </summary>
    HARM_CATEGORY_VIOLENCE,

    /// <summary>
    /// **PaLM** - Contains references to sexual acts or other lewd content.
    /// </summary>
    HARM_CATEGORY_SEXUAL,

    /// <summary>
    /// **PaLM** - Promotes unchecked medical advice.
    /// </summary>
    HARM_CATEGORY_MEDICAL,

    /// <summary>
    /// **PaLM** - Dangerous content that promotes, facilitates, or encourages harmful acts.
    /// </summary>
    HARM_CATEGORY_DANGEROUS,

    /// <summary>
    /// **Gemini** - Harassment content.
    /// </summary>
    HARM_CATEGORY_HARASSMENT,

    /// <summary>
    /// **Gemini** - Hate speech and content.
    /// </summary>
    HARM_CATEGORY_HATE_SPEECH,

    /// <summary>
    /// **Gemini** - Sexually explicit content.
    /// </summary>
    HARM_CATEGORY_SEXUALLY_EXPLICIT,

    /// <summary>
    /// **Gemini** - Dangerous content.
    /// </summary>
    HARM_CATEGORY_DANGEROUS_CONTENT,

    /// <summary>
    /// **Gemini** - Content that may be used to harm civic integrity.
    /// </summary>
    HARM_CATEGORY_CIVIC_INTEGRITY,
}