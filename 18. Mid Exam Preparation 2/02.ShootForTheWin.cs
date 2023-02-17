//INPUT
int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

//ACTION
string command = string.Empty;
int shotTargets = 0;

while ((command = Console.ReadLine()) != "End")
{
    int index = int.Parse(command);
	int value;

	if (index >= 0 && index < targets.Length && targets[index] != -1)
	{
		shotTargets++;
		value = targets[index];
		targets[index] = -1;

		for (int i = 0; i < targets.Length; i++)
		{
			if (targets[i] != -1 && targets[i] > value)
			{
				targets[i] -= value;
            }
			else if (targets[i] != -1 && targets[i] <= value)
            {
                targets[i] += value;
            }
		}
	}
}

//OUTPUT
Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
