using System;
using System.Text;

//INPUT
StringBuilder stops = new StringBuilder(Console.ReadLine());
string command = string.Empty;

//ACTION
while ((command = Console.ReadLine()) != "Travel")
{
    string[] commandArray = command.Split(":");

    //Add Command
    if (command.Contains("Add Stop"))
    {
        int index = int.Parse(commandArray[1]);
        string newStop = (commandArray[2]);

        //Valid Index Checker
        if (index < stops.Length && index >= 0)
        {
            stops.Insert(index, newStop);
        }
        Console.WriteLine(stops);
    }

    //Remove Command
    else if (command.Contains("Remove Stop"))
    {
        int startIndex = int.Parse(commandArray[1]);
        int endIndex = int.Parse(commandArray[2]);

        //Valid Indexes Checker
        if (startIndex < stops.Length && startIndex >= 0 && endIndex < stops.Length && endIndex >= 0)
        {
            stops.Remove(startIndex, endIndex-startIndex+1);
        }
        Console.WriteLine(stops);
    }

    //Switch Command
    else if (command.Contains("Switch"))
    {
        string oldString = (commandArray[1]);
        string newString = (commandArray[2]);

        if (stops.ToString().Contains(oldString))
        {
            stops.Replace(oldString, newString);
        }
        Console.WriteLine(stops);
    }
}

//OUTPUT
Console.WriteLine($"Ready for world tour! Planned stops: {stops}");