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

//OUTPUT
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

//Anno 1681. The Caribbean. The golden age of piracy. You are a well-known
//pirate captain by the name of Jack Daniels. Together with your comrades
//Jim (Beam) and Johnny (Walker), you have been roaming the seas, looking
//for gold and treasure… and the occasional killing, of course. Go ahead,
//target some wealthy settlements and show them the pirate's way!

//Until the "Sail" command is given, you will be receiving:
//You and your crew have targeted cities, with their population and gold,
//separated by "||".

//If you receive a city that has already been received, you have to
//increase the population and gold with the given values.
//After the "Sail" command, you will start receiving lines of text
//representing events until the "End" command is given. 

//Events will be in the following format:

// - "Plunder=>{town}=>{people}=>{gold}"
//You have successfully attacked and plundered the town, killing the given
//number of people and stealing the respective amount of gold. 
//For every town you attack print this message: "{town} plundered! {gold}
//gold stolen, {people} citizens killed."
//If any of those two values (population or gold) reaches zero, the town
//is disbanded. You need to remove it from your collection of targeted
//cities and print the following message: "{town} has been wiped off
//the map!"
//There will be no case of receiving more people or gold than there is in
//the city.

// - "Prosper=>{town}=>{gold}"
//There has been dramatic economic growth in the given city, increasing
//it's treasury by the given amount of gold.
//The gold amount can be a negative number, so be careful. If a negative
//amount of gold is given, print: "Gold added cannot be a negative number!"
//and ignore the command.
//If the given gold is a valid amount, increase the town's gold reserves by
//the respective amount and print the following message: 
//"{gold added} gold added to the city treasury. {town} now has {total gold} gold."
