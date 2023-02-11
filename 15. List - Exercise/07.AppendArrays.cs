//INPUT
using System;

List<string> inputList = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

//ACTION
List<int> outputList = new List<int>();

for (int i = 0; i < inputList.Count; i++)
{
    string currentNum = inputList[i];
    int[] currentNumbersArray = currentNum.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int j = 0; j < currentNumbersArray.Length; j++)
    {
        outputList.Insert(j, currentNumbersArray[j]);
    }
}

for (int j = 0; j < outputList.Count; j++)
{
    Console.Write($"{outputList[j]} ");
}