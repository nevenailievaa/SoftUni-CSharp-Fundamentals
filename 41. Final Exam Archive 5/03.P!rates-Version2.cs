//INPUT
string command = string.Empty;

//ACTION
List<City> citiesList = new List<City>();

while ((command = Console.ReadLine()) != "Sail")
{
    string[] commandArray = command.Split("||");
    string cityName = commandArray[0];
    int population = int.Parse(commandArray[1]);
    int gold = int.Parse(commandArray[2]);

    City currentCity = new City(cityName, population, gold);
    bool alreadyCity = false;

    if (citiesList.Count == 0)
    {
        citiesList.Add(currentCity);
    }
    else
    {
        for (int i = 0; i < citiesList.Count; i++)
        {
            if (citiesList[i].Name == cityName)
            {
                alreadyCity = true;
                citiesList[i].Population += population;
                citiesList[i].Gold += gold;
            }
        }
        if (!alreadyCity)
        {
            citiesList.Add(currentCity);
        }
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

        for (int i = 0; i < citiesList.Count; i++)
        {
            if (citiesList[i].Name == town)
            {
                citiesList[i].Population -= people;
                citiesList[i].Gold -= gold;
                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            }
            if (citiesList[i].Population <= 0 || citiesList[i].Gold <= 0)
            {
                citiesList.Remove(citiesList[i]);
                Console.WriteLine($"{town} has been wiped off the map!");
            }
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
            for (int i = 0; i < citiesList.Count; i++)
            {
                if (citiesList[i].Name == town)
                {
                    citiesList[i].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesList[i].Gold} gold.");
                }
            }
        }
    }
}

//OUTPUT
if (citiesList.Count == 0)
{
    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {citiesList.Count} wealthy settlements to go to:");
    foreach (var town in citiesList)
    {
        Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
    }
}

//City Class
public class City
{
    public string Name { get; set; }
    public int Population { get; set; }
    public int Gold { get; set; }

    public City (string name, int population, int gold)
    {
        Name = name;
        Population = population;
        Gold = gold;
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