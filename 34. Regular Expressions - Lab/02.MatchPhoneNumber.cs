using System.Text.RegularExpressions;

//INPUT
string numbers = Console.ReadLine();

//ACTION
Regex numbersRegex = new Regex(@"\+359( |-)[2]\1\d{3}\1\d{4}\b");

MatchCollection matchCollection = numbersRegex.Matches(numbers);

//OUTPUT
Console.WriteLine(String.Join(", ", matchCollection));