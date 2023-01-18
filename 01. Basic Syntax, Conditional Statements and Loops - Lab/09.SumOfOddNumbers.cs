//INPUT
int repeatTimes = int.Parse(Console.ReadLine()) * 2;

//CHANGEABLE
int sum = 0;

//ACTION
for (int i = 1; i <= repeatTimes; i++)
{
	if (i % 2 == 1)
	{
		Console.WriteLine(i);
		sum += i;
	}
}

//OUTPUT
Console.WriteLine($"Sum: {sum}");