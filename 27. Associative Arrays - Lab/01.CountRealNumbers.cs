//INPUT
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

//ACTION
SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

foreach (int number in numbers)
{
	if (!sortedNumbers.ContainsKey(number))
	{
		sortedNumbers.Add(number, 1);
	}
	else
	{
		sortedNumbers[number] += 1;
	}
}

//OUTPUT
foreach (var num in sortedNumbers)
{
	Console.WriteLine($"{num.Key} -> {num.Value}");
}