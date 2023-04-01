using System.Numerics;
using System.Text.RegularExpressions;

//INPUT
string inputText = Console.ReadLine();

//Regexes
Regex numbersRegex = new Regex(@"(?<numbers>[0-9])");
Regex emojisRegex = new Regex(@"(?<separator>\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\k<separator>");

//ACTION
//Numbers
ulong coolThreshold = 1U;
MatchCollection numbersMatches = numbersRegex.Matches(inputText);

foreach (Match match in numbersMatches)
{
    coolThreshold *= ulong.Parse(match.Value);
}

//Emojis
MatchCollection emojisMatches = emojisRegex.Matches(inputText);
List<string> validEmojis = new List<string>();

foreach (var emoji in emojisMatches)
{
    string currentEmoji = emoji.ToString();
    ulong currentCoolness = 0U;

    for (int i = 2; i < currentEmoji.Length-2; i++)
    {
        currentCoolness += currentEmoji[i];
    }
    if (currentCoolness >= coolThreshold)
    {
        validEmojis.Add(currentEmoji);
    }
}

//OUTPUT
Console.WriteLine($"Cool threshold: {coolThreshold}");
Console.WriteLine($"{emojisMatches.Count} emojis found in the text. The cool ones are:");
Console.WriteLine(String.Join("\n", validEmojis));