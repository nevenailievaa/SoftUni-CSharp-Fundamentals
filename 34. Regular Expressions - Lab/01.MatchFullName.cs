using System.Text.RegularExpressions;

//INPUT
string names = Console.ReadLine();

//ACTION
Regex nameRegex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

MatchCollection matchCollection = nameRegex.Matches(names);

//OUTPUT
Console.WriteLine(String.Join(" ", matchCollection));