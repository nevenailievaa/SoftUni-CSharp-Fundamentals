using System.Text;

//INPUT
string encryptedMessage = Console.ReadLine();
StringBuilder decryptedMessage = new StringBuilder(encryptedMessage);

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "Decode")
{
    string[] commandArray = command.Split("|");

    //Move Command
    if (command.Contains("Move"))
	{
		int numberOfLettersToMove = int.Parse(commandArray[1]);
        string lettersToMove = decryptedMessage.ToString().Substring(0, numberOfLettersToMove);

        decryptedMessage.Remove(0, numberOfLettersToMove);
        decryptedMessage.Append(lettersToMove);
    }

    //Insert Command
	else if (command.Contains("Insert"))
	{
        int index = int.Parse(commandArray[1]);
        string insertValue = commandArray[2];

        decryptedMessage = decryptedMessage.Insert(index, insertValue);
    }

    //ChangeAll Command
    else if (command.Contains("ChangeAll"))
	{
        char substringToChange = char.Parse(commandArray[1]);
        char replacement = char.Parse(commandArray[2]);

        for (int i = 0; i < decryptedMessage.Length; i++)
        {
            if (decryptedMessage[i] == substringToChange)
            {
                decryptedMessage[i] = replacement;
            }
        }
    }
}

//OUTPUT
Console.WriteLine($"The decrypted message is: {decryptedMessage}");