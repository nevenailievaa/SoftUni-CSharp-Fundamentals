using System;
using System.Text;
using System.Text.RegularExpressions;

//INPUT
string input = Console.ReadLine();

//ACTION
Regex pairsRegex = new Regex(@"(?<Separator>#|@)(?<Word>[A-Za-z]{3,})\k<Separator>{2}(?<WordTwo>[A-Za-z]{3,})");
MatchCollection matches = pairsRegex.Matches(input);

Dictionary<string, string> mirroredWords = new Dictionary<string, string>();

foreach (Match match in matches)
{
    char[] wordTwoArray = (match.Groups["WordTwo"].Value).ToCharArray();
    Array.Reverse(wordTwoArray);
    string wordTwoReversed = new string(wordTwoArray);

    if (match.Groups["Word"].Value == wordTwoReversed)
    {
        string wordOne = match.Groups["Word"].Value;
        string wordTwo = match.Groups["WordTwo"].Value;
        mirroredWords.Add(wordOne, wordTwo);
    }
}

//OUTPUT
List<StringBuilder> outputWords = new List<StringBuilder>();

if (matches.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}

if (mirroredWords.Count > 0)
{
    Console.WriteLine("The mirror words are:");
    foreach (var word in mirroredWords)
    {
        StringBuilder currentMirroredWords = new StringBuilder();
        currentMirroredWords.Append(word.Key);
        currentMirroredWords.Append(" <=> ");
        currentMirroredWords.Append(word.Value);

        outputWords.Add(currentMirroredWords);
    }
    Console.WriteLine(string.Join(", ", outputWords));
}
else
{
    Console.WriteLine("No mirror words!");
}