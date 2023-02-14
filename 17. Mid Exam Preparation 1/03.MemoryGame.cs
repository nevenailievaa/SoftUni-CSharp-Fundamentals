//INPUT
List<string> elementsList = Console.ReadLine().Split().ToList();
string command = string.Empty;
int movesCount = 0;

//ACTION
while ((command = Console.ReadLine()) != "end")
{
    movesCount++;
    string[] commandArray = command.Split();
    int indexOne = Convert.ToInt32(commandArray[0].ToString());
    int indexTwo = Convert.ToInt32(commandArray[1].ToString());

    //Invalid Index Input
    if (indexOne == indexTwo || indexOne < 0 || indexOne >= elementsList.Count || indexTwo < 0 || indexTwo >= elementsList.Count)
    {
        int middleIndex = elementsList.Count / 2;
        elementsList.Insert(middleIndex, $"-{movesCount}a");
        elementsList.Insert(middleIndex, $"-{movesCount}a");
        Console.WriteLine("Invalid input! Adding additional elements to the board");
    }
    else
    {
        //Two Matching Elements
        if (elementsList[indexOne] == elementsList[indexTwo])
        {
            Console.WriteLine($"Congrats! You have found matching elements - {elementsList[indexOne]}!");

            //Indexes Checker
            if (indexOne < indexTwo)
            {
                elementsList.RemoveAt(indexOne);
                elementsList.RemoveAt(indexTwo-1);
            }
            else
            {
                elementsList.RemoveAt(indexOne);
                elementsList.RemoveAt(indexTwo);
            }
        }
        //Two Not Matching Elements
        else if (elementsList[indexOne] != elementsList[indexTwo])
        {
            Console.WriteLine("Try again!");
        }

        //Elements List Length Ckecker
        if (elementsList.Count == 0)
        {
            break;
        }
    }
}

//OUTPUT
if (elementsList.Count == 0)
{
    Console.WriteLine($"You have won in {movesCount} turns!");
}
else
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(String.Join(" ", elementsList));
}