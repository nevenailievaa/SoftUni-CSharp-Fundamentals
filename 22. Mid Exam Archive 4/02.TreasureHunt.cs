//INPUT
List<string> treasureChest = Console.ReadLine().Split("|").ToList();

//ACTION
string command = string.Empty;
while ((command = Console.ReadLine()) != "Yohoho!")
{
	string[] commandArray = command.Split();

    //Loot Command
	if (commandArray[0] == "Loot")
	{
        for (int i = 1; i < commandArray.Length; i++)
        {
            //Already In The List Checker
            if (treasureChest!.Contains(commandArray[i])) { }
            else
            {
                treasureChest.Insert(0, commandArray[i]);
            }
        }
	}

    //Drop Command
    else if (commandArray[0] == "Drop")
    {
        int index = int.Parse(commandArray[1]);

        //Index Check
        if (index >= 0 && index < treasureChest.Count)
        {
            string currentLoot = treasureChest[index];
            treasureChest.RemoveAt(index);
            treasureChest.Add(currentLoot);
        }
    }

    //Steal Command
    else if (commandArray[0] == "Steal")
    {
        int stealItemsCount = int.Parse(commandArray[1]);

        while (stealItemsCount > treasureChest.Count)
        {
            stealItemsCount--;
        }
        List<string> stolenItemsList = new List<string>();

        for (int i = treasureChest.Count - stealItemsCount; i < treasureChest.Count; i++)
        {
            stolenItemsList.Add(treasureChest[i]);
        }
        
        //Removing Stolen Items
        treasureChest.RemoveRange(treasureChest.Count - stealItemsCount, stealItemsCount);

        //Stolen Items Print
        Console.WriteLine(String.Join(", ", stolenItemsList));
    }
}

//Sum Calculation
double sum = 0;

for (int i = 0; i < treasureChest.Count; i++)
{
    string currentString = treasureChest[i];
    sum += currentString.Length;
}
sum /= treasureChest.Count;

//OUTPUT
if (treasureChest.Count > 0)
{
    Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");
}
else
{
    Console.WriteLine("Failed treasure hunt.");
}