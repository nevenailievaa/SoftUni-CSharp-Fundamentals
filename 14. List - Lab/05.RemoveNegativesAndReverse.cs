//INPUT
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
int numbersCnt = numbers.Count;

//CHANGEABLE DATA
int negativeNumsCnt = 0;

//ACTION
for (int i = 0; i < numbers.Count; i++)
{
	if (numbers[i] < 0)
	{
		negativeNumsCnt += 1;
		numbers.RemoveAt(i);
		i -= 1;
	}
}

//OUTPUT
if (negativeNumsCnt == numbersCnt)
{
	Console.WriteLine("empty");
}
else
{
	numbers.Reverse();
	Console.WriteLine(String.Join(" ", numbers));
}