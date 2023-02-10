//INPUT
List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int wagonsCapacity = int.Parse(Console.ReadLine());

//ACTION
string command = String.Empty;

while ((command = Console.ReadLine()) != "end")
{
	if (command.Contains("Add"))
	{
		int passengersAdd = int.Parse(command.Split()[1]);
		wagons.Add(passengersAdd);
	}
	else
	{
		int inputPassengers = Convert.ToInt32(command);
		for (int i = 0; i < wagons.Count; i++)
		{
			if (inputPassengers <= wagonsCapacity - wagons[i])
			{
				wagons[i] += inputPassengers;
				break;
			}
		}
	}
}

//OUTPUT
Console.Write(string.Join(" ", wagons));