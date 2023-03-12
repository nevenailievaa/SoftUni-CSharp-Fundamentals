//INPUT
using System.Globalization;

string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

//ACTION
foreach (var bannedWord in bannedWords)
{
    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
}

//OUTPUT
Console.WriteLine(text);