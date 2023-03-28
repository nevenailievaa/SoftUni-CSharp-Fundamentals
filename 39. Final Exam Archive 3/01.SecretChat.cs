using System.Text;

//INPUT
StringBuilder message = new StringBuilder(Console.ReadLine());

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "Reveal")
{
    string[] commandArray = command.Split(":|:");

    //InsertSpace Command
    if (command.Contains("InsertSpace"))
	{
        int index = int.Parse(commandArray[1]);
        message.Insert(index, " ");

        //Output
        Console.WriteLine(message);
    }

    //Reverse Command
    else if (command.Contains("Reverse"))
    {
        string givenSubstring = commandArray[1];

        string messageString = message.ToString();
        int index = messageString.IndexOf(givenSubstring);

        if (messageString.Contains(givenSubstring))
        {
            message.Remove(index, givenSubstring.Length);

            //Reverse
            char[] stringArray = givenSubstring.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);
            message.Append(reversedString);

            //Output
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    //ChangeAll Command
    else if (command.Contains("ChangeAll"))
    {
        string givenSubstring = commandArray[1];
        string replacement = commandArray[2];

        for (int i = 0; i < message.Length; i++)
        {
            message.Replace(givenSubstring, replacement);
        }

        //Output
        Console.WriteLine(message);
    }
}

//OUTPUT
Console.WriteLine($"You have a new text message: {message}");

//You have plenty of free time, so you decide to write a program that
//conceals and reveals your received messages. Go ahead and type it in!

//On the first line of the input, you will receive the concealed message.
//After that, until the "Reveal" command is given, you will receive strings
//with instructions for different operations that need to be performed upon
//the concealed message to interpret it and reveal its actual content. There
//are several types of instructions, split by ":|:"

// - "InsertSpace:|:{index}":
//Inserts a single space at the given index. The given index will always be valid.

// - "Reverse:|:{substring}":
//If the message contains the given substring, cut it out, reverse it and add it
//at the end of the message. 
//If not, print "error".
//This operation should replace only the first occurrence of the given substring if
//there are two or more occurrences.

// - "ChangeAll:|:{substring}:|:{replacement}":
//Changes all occurrences of the given substring with the replacement text.
