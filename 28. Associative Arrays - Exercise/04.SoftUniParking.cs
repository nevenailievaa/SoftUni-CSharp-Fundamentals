//INPUT
int commandsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, string> parkedCars = new Dictionary<string, string>();

for (int i = 0; i < commandsCount; i++)
{
    string[] commandArray = Console.ReadLine().Split();

	//Register Command
	if (commandArray[0] == "register")
	{
		string username = commandArray[1];
        string plate = commandArray[2];

		if (!parkedCars.ContainsKey(username))
		{
            parkedCars.Add(username, plate);
			Console.WriteLine($"{username} registered {plate} successfully");
        }
		else
		{
			Console.WriteLine($"ERROR: already registered with plate number {plate}");
		}
    }

    //Unregister Command
    else if (commandArray[0] == "unregister")
    {
        string username = commandArray[1];

        if (!parkedCars.ContainsKey(username))
        {

            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            parkedCars.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}

//OUTPUT
foreach (var user in parkedCars)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}