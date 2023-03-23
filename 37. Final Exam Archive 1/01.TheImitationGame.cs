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

//During World War 2, you are a mathematician who has joined the cryptography team to
//decipher the enemy's enigma code. Your job is to create a program to crack the codes. 

//On the first line of the input, you will receive the encrypted message. After that,
//until the "Decode" command is given, you will be receiving strings with instructions
//for different operations that need to be performed upon the concealed message to interpret
//it and reveal its true content. There are several types of instructions, split by '|'

//"Move {number of letters}":
//- Moves the first n letters to the back of the string

//"Insert {index} {value}":
//- Inserts the given value before the given index in the string

//"ChangeAll {substring} {replacement}":
//- Changes all occurrences of the given substring with the replacement text
