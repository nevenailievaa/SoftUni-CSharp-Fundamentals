//INPUT
using System.Text.RegularExpressions;

string dates = Console.ReadLine();

//ACTION
Regex dateRegex = new Regex(@"(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");

MatchCollection datesMatches = dateRegex.Matches(dates);

//OUTPUT
foreach (Match date in datesMatches)
{
    Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
}