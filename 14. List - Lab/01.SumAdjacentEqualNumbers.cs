//INPUT
List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

//ACTION
for (int i = 0; i < numbers.Count -1; i++)
{
    if (numbers[i] == numbers[i+1])
    {
        numbers[i] += numbers[i+1];
        numbers.RemoveAt(i+1);
        i = -1;
    }
}

//OUTPUT
Console.WriteLine(String.Join(" ", numbers));