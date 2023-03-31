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