//INPUT
int numberCommands = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();

//ACTION
for (int i = 0; i < numberCommands; i++)
{
    string command = Console.ReadLine();

    string[] commandArray = command.Split().ToArray();
    string guestName = commandArray[0].ToString();

    if (command.Contains("is going!"))
    {
        if (guests.Contains(guestName))
        {
            Console.WriteLine($"{guestName} is already in the list!");
        }
        else
        {
            guests.Add(guestName);
        }
    }
    else if (command.Contains("is not going!"))
    {
        if (guests.Contains(guestName))
        {
            guests.Remove(guestName);
        }
        else
        {
            Console.WriteLine($"{guestName} is not in the list!");
        }
    }
}
//OUTPUT
foreach (string name in guests)
{
    Console.WriteLine(name);
}
