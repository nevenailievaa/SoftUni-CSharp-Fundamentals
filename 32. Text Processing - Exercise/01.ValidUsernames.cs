//INPUT
string[] inputArray = Console.ReadLine().Split(", "); //95 45

//ACTION
List<string> validUsenames = new List<string>();

for (int i = 0; i < inputArray.Length; i++)
{
    bool isValid = false;
    if (inputArray[i].Length > 2 && inputArray[i].Length < 17)
	{
        char[] currentUsernameChars = inputArray[i].ToCharArray();

		for (int j = 0; j < currentUsernameChars.Length; j++)
		{
			//Letters
			if (Char.IsLetter(currentUsernameChars[j]))
			{
                isValid = true;
            }
            //Numbers
			else if (Char.IsDigit(currentUsernameChars[j]))
            {
                isValid = true;
            }
            //Hyphens
			else if (currentUsernameChars[j] == 45)
            {
                isValid = true;
            }
            //Underscores
            else if (currentUsernameChars[j] == 95)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
                break;
            }
        }
	}

    if (isValid)
    {
        validUsenames.Add(inputArray[i]);
    }
}

//OUTPUT
foreach (var username in validUsenames)
{
    Console.WriteLine(username);
}

//Create a program that reads user names on a single line (joined by ", ")
//and prints all valid usernames.
//A valid username:
//· has length between 3 and 16 characters
//· contains only letters, numbers, hyphens and underscores
