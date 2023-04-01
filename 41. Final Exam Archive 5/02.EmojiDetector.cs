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

//Your task is to write a program that extracts emojis from a text and find
//the threshold based on the input.
//You have to get your cool threshold. It is obtained by multiplying all the
//digits found in the input.  The cool threshold could be a huge number, so
//be mindful.

//An emoji is valid when:
//- It is surrounded by 2 characters, either "::" or "**"
//- It is at least 3 characters long (without the surrounding symbols)
//- It starts with a capital letter
//- Continues with lowercase letters only

//Examples of valid emojis: ::Joy::, **Banana**, ::Wink::
//Examples of invalid emojis: ::Joy**, ::fox:es:, **Monk3ys**, :Snak::Es::

//You need to count all valid emojis in the text and calculate their coolness.
//The coolness of the emoji is determined by summing all the ASCII values of
//all letters in the emoji. 
//Examples: ::Joy:: - 306, **Banana** - 577, ::Wink:: - 409
//You need to print the result of the cool threshold and, after that to take
//all emojis out of the text, count them and print only the cool ones on the
//console.
