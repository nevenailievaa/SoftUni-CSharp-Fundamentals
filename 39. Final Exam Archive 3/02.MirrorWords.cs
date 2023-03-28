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

//The SoftUni Spelling Bee competition is here. But it`s not like any other
//Spelling Bee competition out there. It`s different and a lot more fun! You,
//of course, are a participant, and you are eager to show the competition that
//you are the best, so go ahead, learn the rules and win!

//On the first line of the input, you will be given a text string. To win the
//competition, you have to find all hidden word pairs, read them, and mark the
//ones that are mirror images of each other.

//First of all, you have to extract the hidden word pairs. Hidden word pairs are:
//Surrounded by "@" or "#" (only one of the two) in the following pattern:
//- #wordOne##wordTwo# or @wordOne@@wordTwo@
//- At least 3 characters long each (without the surrounding symbols)
//- Made up of letters only

//If the second word, spelled backward, is the same as the first word and vice versa
//(casing matters!), they are a match, and you have to store them somewhere. Examples
//of mirror words: 
//#Part##traP# @leveL@@Level@ #sAw##wAs#

//If you don`t find any valid pairs, print: "No word pairs found!"
//If you find valid pairs print their count: "{valid pairs count} word pairs found!"
//If there are no mirror words, print: "No mirror words!"
//If there are mirror words print:
//"The mirror words are:
//{wordOne} <=> {wordtwo}, {wordOne} <=> {wordtwo}, … {wordOne} <=> {wordtwo}"
