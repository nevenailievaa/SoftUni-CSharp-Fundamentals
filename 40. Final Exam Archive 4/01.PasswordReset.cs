using System.Text;

//INPUT
StringBuilder password = new StringBuilder(Console.ReadLine());

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "Done")
{
    string[] commandArray = command.Split();
    string commandType = commandArray[0];

    StringBuilder newRawPassword = new StringBuilder();

    //TakeOdd Command
    if (commandType == "TakeOdd")
    {
        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 == 1)
            {
                newRawPassword.Append(password[i]);
            }
        }
        password.Clear();
        password = newRawPassword;
        Console.WriteLine(newRawPassword);
    }

    //Cut Command
    else if (commandType == "Cut")
    {
        int index = int.Parse(commandArray[1]);
        int length = int.Parse(commandArray[2]);

        password.Remove(index, length);
        Console.WriteLine(password);
    }

    //Substitute Command
    else if (commandType == "Substitute")
    {
        string substring = commandArray[1];
        string substitute = commandArray[2];

        if (password.ToString().Contains(substring))
        {
            password.Replace(substring, substitute);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
}

//OUTPUT
Console.WriteLine($"Your password is: {password}");

//Yet again, you have forgotten your password. Naturally, it's not the first time
//this has happened. Actually, you got so tired of it that you decided to help yourself
//with an intelligent solution.

//Write a password reset program that performs a series of commands upon a predefined string.
//First, you will receive a string, and afterward, until the command "Done" is given, you will
//be receiving strings with commands split by a single space. The commands will be the following:

//- "TakeOdd"
// Takes only the characters at odd indices and concatenates them to obtain the new raw password
//and then prints it.

//- "Cut {index} {length}"
//Gets the substring with the given length starting from the given index from the password and
//removes its first occurrence, then prints the password on the console.
//The given index and the length will always be valid.

//- "Substitute {substring} {substitute}"
//If the raw password contains the given substring, replaces all of its occurrences with the
//substitute text given and prints the result.
//If it doesn't, prints "Nothing to replace!".
