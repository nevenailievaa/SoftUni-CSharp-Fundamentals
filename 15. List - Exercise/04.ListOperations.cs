//INPUT
List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

//ACTIONS
string command = string.Empty;
while((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split().ToArray();

	if (command.Contains("Add"))
    {
        int number = Convert.ToInt32(commandArray[1].ToString());
        list.Add(number);
	}
	else if (command.Contains("Insert"))
    {
        int number = Convert.ToInt32(commandArray[1].ToString());
        int index = Convert.ToInt32(commandArray[2].ToString());

        if (index >= list.Count || index < 0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            list.Insert(index, number);
        }
    }
    else if (command.Contains("Remove"))
    {
        int index = Convert.ToInt32(commandArray[1].ToString());
        if (index >= list.Count || index < 0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            list.RemoveAt(index);
        }
    }
    else if (command.Contains("Shift left"))
    {
        int repeatCount = Convert.ToInt32(commandArray[2].ToString());
        for (int i = 0; i < repeatCount; i++)
        {
            list.Add(list[0]);
            list.RemoveAt(0);
        }
    }
    else if (command.Contains("Shift right"))
    {
        int repeatCount = Convert.ToInt32(commandArray[2].ToString());
        for (int i = 0; i < repeatCount; i++)
        {
            list.Insert(0, list[list.Count-1]);
            list.RemoveAt(list.Count-1);
        }
    }
}

//OUTPUT
Console.WriteLine(string.Join(" ", list));