//INPUT
string command = string.Empty;

//ACTION
Dictionary<string, int> cityAndPopulation = new Dictionary<string, int>();
Dictionary<string, int> cityAndGold = new Dictionary<string, int>();

while ((command = Console.ReadLine()) != "Sail")
{
    string[] commandArray = command.Split("||");
    string cityName = commandArray[0];
    int population = int.Parse(commandArray[1]);
    int gold = int.Parse(commandArray[2]);

    if (cityAndPopulation.ContainsKey(cityName))
    {
        cityAndPopulation[cityName] += population;
        cityAndGold[cityName] += gold;
    }
    else
    {
        cityAndPopulation.Add(cityName, population);
        cityAndGold.Add(cityName, gold);
    }
}

while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split("=>");
    string commandType = commandArray[0];

    //Plunder Command
    if (commandType == "Plunder")
    {
        string town = commandArray[1];
        int people = int.Parse(commandArray[2]);
        int gold = int.Parse(commandArray[3]);

        cityAndPopulation[town] -= people;
        cityAndGold[town] -= gold;
        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

        if (cityAndPopulation[town] <= 0 || cityAndGold[town] <= 0)
        {
            cityAndPopulation.Remove(town);
            cityAndGold.Remove(town);
            Console.WriteLine($"{town} has been wiped off the map!");
        }
    }

    //Prosper Command
    else if (commandType == "Prosper")
    {
        string town = commandArray[1];
        int gold = int.Parse(commandArray[2]);

        if (gold < 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
        }
        else
        {
            cityAndGold[town] += gold;
            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityAndGold[town]} gold.");
        }
    }
}

if (cityAndPopulation.Count == 0)
{
    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {cityAndPopulation.Count} wealthy settlements to go to:");
    foreach (var town in cityAndPopulation)
    {
        Console.WriteLine($"{town.Key} -> Population: {town.Value} citizens, Gold: {cityAndGold[town.Key]} kg");
    }
}