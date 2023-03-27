using System.Linq;

//INPUT
int plantsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, int> plantAndRarity = new Dictionary<string, int>();
for (int i = 0; i < plantsCount; i++)
{
    string[] input = Console.ReadLine().Split("<->");
    string plantName = input[0];
    int plantRarity = int.Parse(input[1]);

    plantAndRarity.Add(plantName, plantRarity);
}


//Plants + Ratings
Dictionary<string, List<int>> plantAndRating = new Dictionary<string, List<int>>();
foreach (var plant in plantAndRarity)
{
    List<int> ratings = new List<int>();
    plantAndRating.Add(plant.Key, ratings);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "Exhibition")
{
    string[] commandArray = command.Split(" ");

    //Rate Command
    if (command.Contains("Rate"))
    {
        string plantName = commandArray[1];
        int plantRating = int.Parse(commandArray[3]);

        //Valid Plant Checker
        if (plantAndRarity.ContainsKey(plantName))
        {
            plantAndRating[plantName].Add(plantRating);
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    //Update Command
    else if (command.Contains("Update"))
    {
        string plantName = commandArray[1];
        int newRarity = int.Parse(commandArray[3]);

        //Valid Plant Checker
        if (plantAndRarity.ContainsKey(plantName))
        {
            plantAndRarity[plantName] = newRarity;
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    //Reset Command
    else if (command.Contains("Reset"))
    {
        string plantName = commandArray[1];

        //Valid Plant Checker
        if (plantAndRating.ContainsKey(plantName))
        {
            plantAndRating[plantName].Clear();
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

//OUTPUT
Console.WriteLine("Plants for the exhibition:");
foreach (var currentPlant in plantAndRarity)
{
    int plantRatingsSum = plantAndRating[currentPlant.Key].Sum();
    int plantRatingsCount = plantAndRating[currentPlant.Key].Count();

    if (plantRatingsCount == 0)
    {
        plantRatingsSum = 0;
        Console.WriteLine($"- {currentPlant.Key}; Rarity: {currentPlant.Value}; Rating: {0:f2}");
    }
    else
    {
        double averageRate = plantRatingsSum / (double)plantRatingsCount;
        Console.WriteLine($"- {currentPlant.Key}; Rarity: {currentPlant.Value}; Rating: {averageRate:f2}");
    }
}

//You have now returned from your world tour. On your way, you have discovered some
//new plants, and you want to gather some information about them and create an exhibition
//to see which plant is highest rated.

//On the first line, you will receive a number n. On the next n lines, you will be
//given some information about the plants that you have discovered in the format:
//"{plant}<->{rarity}".Store that information because you will need it later. If
//you receive a plant more than once, update its rarity.

//After that, until you receive the command "Exhibition", you will be given some of
//these commands:

//"Rate: {plant} - {rating}" – add the given rating to the plant (store all ratings)
//"Update: {plant} - {new_rarity}" – update the rarity of the plant with the new one
//"Reset: {plant}" – remove all the ratings of the given plant

//Note: If any given plant name is invalid, print "error"

//After the command "Exhibition", print the information that you have about the plants
//in the following format:

//"Plants for the exhibition:
//- { plant_name1}; Rarity: { rarity}; Rating: { average_rating}
//- { plant_name2}; Rarity: { rarity}; Rating: { average_rating}
//- { plant_nameN}; Rarity: { rarity}; Rating: { average_rating}

//The average rating should be formatted to the second decimal place.
