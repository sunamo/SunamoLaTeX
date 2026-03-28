# SunamoLaTeX

A .NET library for converting LaTeX symbol notation to Unicode characters. Maps over 2400 LaTeX commands (e.g. `\alpha`, `\rightarrow`, `\sum`) to their corresponding Unicode equivalents.

## Installation

```bash
dotnet add package SunamoLaTeX
```

## Usage

```csharp
using SunamoLaTeX;

string unicode = LatexHelper.ConvertToUnicode("\\alpha + \\beta = \\gamma");
// Result: "α + β = γ"
```

## Target Frameworks

`net10.0`, `net9.0`, `net8.0`

## Links

- [NuGet](https://www.nuget.org/packages/SunamoLaTeX)
- [GitHub](https://github.com/sunamo/SunamoLaTeX)
- [Developer site](https://sunamo.cz)

## License

MIT
