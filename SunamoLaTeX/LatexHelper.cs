namespace SunamoLaTeX;

// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
public partial class LatexHelper
{
    public static Dictionary<string, string> texSymbols = new();
    public static string ConvertToUnicode(string input)
    {
        Init();
        foreach (var item in texSymbols)
            input = input.Replace(item.Key, item.Value);
        return input;
    }
}