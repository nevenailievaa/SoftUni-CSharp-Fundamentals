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
//Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

//You are a world traveler, and your next goal is to make a world tour. To do that, you have to plan out
//everything first. To start with, you would like to plan out all of your stops where you will have a break.
//On the first line, you will be given a string containing all of your stops. Until you receive the command
//"Travel", you will be given some commands to manipulate that initial string. The commands can be:

//"Add Stop:{index}:{string}":
//Insert the given string at that index only if the index is valid

//"Remove Stop:{start_index}:{end_index}":
//Remove the elements of the string from the starting index to the end index (inclusive) if both indices are valid

//"Switch:{old_string}:{new_string}":
//If the old string is in the initial string, replace it with the new one (all occurrences)

//Note: After each command, print the current state of the string!
//After the "Travel" command, print the following: "Ready for world tour! Planned stops: {string}"
