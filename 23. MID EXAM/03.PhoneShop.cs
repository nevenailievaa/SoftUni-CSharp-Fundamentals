//INPUT
List<string> phoneTypesList = Console.ReadLine().Split(", ").ToList();

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split();

	//Add Command
	if (commandArray[0] == "Add")
	{
		string currentPhone = commandArray[2];

		if (phoneTypesList.Contains(currentPhone)) { }
		else
		{
			phoneTypesList.Add(currentPhone);
		}
	}

    //Remove Command
    if (commandArray[0] == "Remove")
    {
        string currentPhone = commandArray[2];

        if (phoneTypesList.Contains(currentPhone))
		{
			phoneTypesList.Remove(currentPhone);
		}
    }

	//Bonus Phone Command
	if (commandArray[0] == "Bonus")
	{
        string[] currentCommand = command.Split().ToArray();
        string[] phones = currentCommand[3].Split(":").ToArray();

        //Exists Check
        string oldPhone = phones[0];
        string newPhone = phones[1];

        for (int i = 0; i < phoneTypesList.Count; i++)
        {
            if (phoneTypesList[i] == oldPhone)
            {
                phoneTypesList.Insert(i + 1, newPhone);
            }
        }
    }

    //Last Command
    if (commandArray[0] == "Last")
    {
        string currentPhone = commandArray[2];

        if (phoneTypesList.Contains(currentPhone))
        {
            phoneTypesList.Remove(currentPhone);
            phoneTypesList.Add(currentPhone);
        }
    }
}

//OUTPUT
Console.WriteLine(string.Join(", ", phoneTypesList));