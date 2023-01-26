//INPUT
int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

//CHANGEABLE
int notIdenticalIndex = -1;
int indexesSum = 0;

//ACTION
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != secondArray[i])
    {
        notIdenticalIndex = i;
        break;
    }
    else
    {
        indexesSum += firstArray[i];
    }

}

//ACTION
if (notIdenticalIndex == -1)
{
    Console.WriteLine($"Arrays are identical. Sum: {indexesSum}");
}
else
{
    Console.WriteLine($"Arrays are not identical. Found difference at {notIdenticalIndex} index");
}