using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

//INPUT
string numbers = Console.ReadLine();

//ACTION
Regex numbersRegex = new Regex(@"\+359( |-)[2]\1\d{3}\1\d{4}\b");

MatchCollection matchCollection = numbersRegex.Matches(numbers);

//OUTPUT
Console.WriteLine(String.Join(", ", matchCollection));


//Create a regular expression to match a valid phone number from Sofia.
//After you find all valid phones, print them on the console, separated
//by a comma and a space ", ".

//A valid number has the following characteristics:

//· It starts with "+359"
//· Then, it is followed by the area code (always 2)
//· After that, it's followed by the number itself:
//· The number consists of 7 digits (separated into
//two groups of 3 and 4 digits respectively).
//· The different parts are separated by either a
//space or a hyphen ('-').
