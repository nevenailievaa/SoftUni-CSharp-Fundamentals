//INPUT
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

//ACTION
for (int i = 0; i < numbers.Count; i++)
{
    if (i != numbers.Count-1)
    {
        //First + Last
        numbers[i] += numbers[numbers.Count-1];
        numbers.RemoveAt(numbers.Count-1);
    }
}
Console.WriteLine(String.Join(" ", numbers));