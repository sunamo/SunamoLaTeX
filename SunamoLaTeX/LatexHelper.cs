namespace SunamoLaTeX;

/// <summary>
/// Represents the latex helper type.
/// </summary>
public partial class LatexHelper
{
    /// <summary>
    /// Gets or sets the tex symbols.
    /// </summary>
    public static Dictionary<string, string> TexSymbols { get; set; } = new();

    /// <summary>
    /// Convert to unicode.
    /// </summary>
    /// <returns>The convert to unicode result.</returns>
    public static string ConvertToUnicode(string latexText)
    {
        init();
        foreach (var item in TexSymbols)
            latexText = latexText.Replace(item.Key, item.Value);
        return latexText;
    }
}
