namespace SunamoLaTeX;

/// <summary>
/// Provides helper methods for converting LaTeX symbols to Unicode characters.
/// </summary>
public partial class LatexHelper
{
    /// <summary>
    /// Gets or sets the dictionary mapping LaTeX symbols to Unicode characters.
    /// </summary>
    public static Dictionary<string, string> TexSymbols { get; set; } = new();

    /// <summary>
    /// Converts LaTeX text to Unicode by replacing LaTeX symbols with their Unicode equivalents.
    /// </summary>
    /// <param name="latexText">The LaTeX text to convert.</param>
    /// <returns>The converted Unicode text.</returns>
    public static string ConvertToUnicode(string latexText)
    {
        Init();
        foreach (var item in TexSymbols)
            latexText = latexText.Replace(item.Key, item.Value);
        return latexText;
    }
}