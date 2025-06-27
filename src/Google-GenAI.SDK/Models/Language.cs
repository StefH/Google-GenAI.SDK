namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Required. Programming language of the `code`.
/// </summary>
public enum Language
{
    /// <summary>
    /// Unspecified language. This value should not be used.
    /// </summary>
    LANGUAGE_UNSPECIFIED,

    /// <summary>
    /// Python >= 3.10, with numpy and simpy available.
    /// </summary>
    PYTHON,
}