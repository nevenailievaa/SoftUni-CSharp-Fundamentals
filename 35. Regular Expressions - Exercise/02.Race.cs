using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

//INPUT
List<string> participantsInputList = Console.ReadLine().Split(", ").ToList();

//ACTION
Regex nameRegex = new Regex(@"[A-Za-z]");
Regex distanceRegex = new Regex(@"\d");

Dictionary<string, int> participants = new Dictionary<string, int>();

int sum = 0;
string command = string.Empty;

while ((command = Console.ReadLine()) != "end of race")
{
    MatchCollection nameMatch = nameRegex.Matches(command);
    MatchCollection distanceNumbers = distanceRegex.Matches(command);

    //Name
    StringBuilder name = new StringBuilder();
    foreach (Match character in nameMatch)
    {
        name.Append(character.Value);
    }
    string currentName = name.ToString();

    //Input Contains The Name
    if (participantsInputList.Contains(currentName.ToString()))
    {
        //Sum Distance
        foreach (Match num in distanceNumbers)
        {
            sum += int.Parse(num.Value);
        }

        //Already Exists Check
        if (participants.ContainsKey(currentName))
        {
            participants[currentName] += sum;
        }
        else
        {
            participants.Add(currentName, sum);
        }
    }

    //Restore
    sum = 0;
}

//OUTPUT
int commandsMade = 0;
foreach (var participant in participants.OrderByDescending(key => key.Value))
{
    commandsMade++;
    if (commandsMade == 1)
    {
        Console.WriteLine($"1st place: {participant.Key}");
    }
    else if (commandsMade == 2)
    {
        Console.WriteLine($"2nd place: {participant.Key}");
    }
    else if (commandsMade == 3)
    {
        Console.WriteLine($"3rd place: {participant.Key}");
    }
}