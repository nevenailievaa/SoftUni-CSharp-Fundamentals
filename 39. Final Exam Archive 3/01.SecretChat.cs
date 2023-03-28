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