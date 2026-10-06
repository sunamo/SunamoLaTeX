namespace SunamoLaTeX;

public partial class LatexHelper
{
    public static Dictionary<string, string> TexSymbols { get; set; } = new();

    public static string ConvertToUnicode(string latexText)
    {
        init();
        foreach (var item in TexSymbols)
            latexText = latexText.Replace(item.Key, item.Value);
        return latexText;
    }
}
