using System.Text.RegularExpressions;

//INPUT
string names = Console.ReadLine();

//ACTION
Regex nameRegex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

MatchCollection matchCollection = nameRegex.Matches(names);

//OUTPUT
Console.WriteLine(String.Join(" ", matchCollection));

//Write a C# Program to match full names from a list of names
//and print them on the console.

//First, create a regular expression to match a valid full name,
//according to these conditions:

//· A valid full name has the following characteristics:
//· It consists of two words.
//· Each word starts with a capital letter.
//· After the first letter, it only contains lowercase letters afterward.
//· Each of the two words should be at least two letters long.
//· The two words are separated by a single space.
