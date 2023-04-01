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

//You are about to make some good money, but first, you need to think of a
//way to verify who paid for your product and who didn't. You have decided
//to let people use the software for a free trial period and then require
//an activation key to continue using the product. Before you can cash out,
//the last step is to design a program that creates unique activation keys
//for each user. So, waste no more time and start typing!

//The first line of the input will be your raw activation key. It will
//consist of letters and numbers only. 

//After that, until the "Generate" command is given, you will be receiving
//strings with instructions for different operations that need to be performed
//upon the raw activation key.

//There are several types of instructions, split by ">>>":
// - "Contains>>>{substring}":
//If the raw activation key contains the given substring, prints:
//"{raw activation key} contains {substring}".
//Otherwise, prints: "Substring not found!"

// - "Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}":
//Changes the substring between the given indices (the end index is exclusive)
//to upper or lower case and then prints the activation key.
//All given indexes will be valid.

// - "Slice>>>{startIndex}>>>{endIndex}":
//Deletes the characters between the start and end indices (the end index is
//exclusive) and prints the activation key.
//Both indices will be valid.
