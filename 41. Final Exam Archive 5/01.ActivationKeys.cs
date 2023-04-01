using System;
using System.Text;

//INPUT
StringBuilder key = new StringBuilder(Console.ReadLine());

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "Generate")
{
    string[] commandArray = command.Split(">>>");
    string commandType = commandArray[0];

    //Contains Command
    if (commandType == "Contains")
    {
        string substring = commandArray[1];

        if (key.ToString().Contains(substring))
        {
            Console.WriteLine($"{key} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }

    //Flip Command
    else if (commandType == "Flip")
    {
        string flipType = commandArray[1];
        int startIndex = int.Parse(commandArray[2]);
        int endIndex = int.Parse(commandArray[3]);

        StringBuilder flippedChars = new StringBuilder();
        string keyString = key.ToString();

        if (flipType == "Upper")
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                flippedChars.Append(keyString[i].ToString().ToUpper());
            }
        }
        else if (flipType == "Lower")
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                flippedChars.Append(keyString[i].ToString().ToLower());
            }
        }

        key.Remove(startIndex, endIndex-startIndex);
        key.Insert(startIndex, flippedChars.ToString());
        Console.WriteLine(key);
    }

    //Slice Command
    else if (commandType == "Slice")
    {
        int startIndex = int.Parse(commandArray[1]);
        int endIndex = int.Parse(commandArray[2]);

        key.Remove(startIndex, endIndex-startIndex);
        Console.WriteLine(key);
    }
}

//OUTPUT
Console.WriteLine($"Your activation key is: {key}");