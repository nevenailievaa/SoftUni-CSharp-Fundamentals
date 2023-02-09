//INPUT
List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

//ACTION
int minValue = Math.Min(firstList.Count, secondList.Count);
int maxValue = Math.Max(firstList.Count, secondList.Count);
List<int> outputList = new List<int>();

for (int i = 0; i < minValue; i++)
{
    outputList.Add(firstList[i]);
    outputList.Add(secondList[i]);
}
if (minValue != maxValue)
{
    for (int i = minValue; i < maxValue; i++)
    {
        if (firstList.Count > secondList.Count)
        {
            outputList.Add(firstList[i]);
        }
        else
        {
            outputList.Add(secondList[i]);
        }
    }
}

//OUTPUT
Console.WriteLine(String.Join(" ", outputList));