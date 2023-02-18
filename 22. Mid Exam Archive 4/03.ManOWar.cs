//INPUT
using System;
using System.Reflection;

List<int> pirateShipList = Console.ReadLine().Split(">").Select(int.Parse).ToList();
List<int> warShipList = Console.ReadLine().Split(">").Select(int.Parse).ToList();
int maximumHealth = int.Parse(Console.ReadLine());

//ACTION
string command = string.Empty;

while ((command = Console.ReadLine()) != "Retire")
{
    string[] commandArray = command.Split();

    //Fire Command
	if (commandArray[0] == "Fire")
	{
        int index = int.Parse(commandArray[1]);
        int damage = int.Parse(commandArray[2]);

        //Index Checker
        if (index >= 0 && index < warShipList.Count)
        {
            //Damage
            warShipList[index] -= damage;
            if (warShipList[index] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                return;
            }
        }
    }

    //Defend Command
	else if (commandArray[0] == "Defend")
    {
        int startIndex = int.Parse(commandArray[1]);
        int endIndex = int.Parse(commandArray[2]);
        int damage = int.Parse(commandArray[3]);

        //Indexes Checker
        if (startIndex >= 0 && startIndex < pirateShipList.Count && endIndex >= 0 && endIndex < pirateShipList.Count)
        {
            //Damage
            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShipList[i] -= damage;
                if (pirateShipList[i] <= 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    return;
                }
            }
        }
    }

    //Repair Command
    else if (commandArray[0] == "Repair")
    {
        int index = int.Parse(commandArray[1]);
        int health = int.Parse(commandArray[2]);

        //Index Checker
        if (index >= 0 && index < pirateShipList.Count)
        {
            pirateShipList[index] += health;

            if (pirateShipList[index] > maximumHealth)
            {
                pirateShipList[index] = maximumHealth;
            }
        }
    }

    //Status Command
    else if (commandArray[0] == "Status")
    {
        double twentyPercentOfHealth = maximumHealth * 0.2;
        int partsForRepairCount = 0;

        for (int i = 0; i < pirateShipList.Count; i++)
        {
            if (pirateShipList[i] < twentyPercentOfHealth)
            {
                partsForRepairCount++;
            }
        }
        Console.WriteLine($"{partsForRepairCount} sections need repair.");
    }
}

//Ships Sum
int pirateShipSum = pirateShipList.Sum();
int warShipSum = warShipList.Sum();

Console.WriteLine($"Pirate ship status: {pirateShipSum}");
Console.WriteLine($"Warship status: {warShipSum}");