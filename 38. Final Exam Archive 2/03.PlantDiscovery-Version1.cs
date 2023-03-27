using System.Linq;

//INPUT
int plantsCount = int.Parse(Console.ReadLine());

//ACTION
List<Plant> plantsList = new List<Plant>();

for (int i = 0; i < plantsCount; i++)
{
    string[] plantAndRarity = Console.ReadLine().Split("<->");
    string plantName = plantAndRarity[0];
    int plantRarity = int.Parse(plantAndRarity[1]);

    Plant currentPlant = new Plant(plantName, plantRarity, 0, 0);
    plantsList.Add(currentPlant);
}


//Plants + Ratings
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
        bool validPlant = false;
        for (int i = 0; i < plantsList.Count; i++)
        {
            if (plantsList[i].PlantName == plantName)
            {
                validPlant = true;
                plantsList[i].Rating += plantRating;
                plantsList[i].RatingsCount++;
            }
        }
        if (!validPlant)
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
        bool validPlant = false;
        for (int i = 0; i < plantsList.Count; i++)
        {
            if (plantsList[i].PlantName == plantName)
            {
                validPlant = true;
                plantsList[i].Rarity = newRarity;
            }
        }
        if (!validPlant)
        {
            Console.WriteLine("error");
        }
    }

    //Reset Command
    else if (command.Contains("Reset"))
    {
        string plantName = commandArray[1];

        //Valid Plant Checker
        bool validPlant = false;
        for (int i = 0; i < plantsList.Count; i++)
        {
            if (plantsList[i].PlantName == plantName)
            {
                validPlant = true;
                plantsList[i].Rating = 0;
                plantsList[i].RatingsCount = 0;
            }
        }
        if (!validPlant)
        {
            Console.WriteLine("error");
        }
    }
}

//OUTPUT
Console.WriteLine("Plants for the exhibition:");
foreach (Plant plant in plantsList)
{
    double averageRating = 0;
    if (plant.RatingsCount == 0)
    {
        averageRating = 0;
    }
    else
    {
        averageRating = plant.Rating / (double)plant.RatingsCount;
    }
    Console.WriteLine($"- {plant.PlantName}; Rarity: {plant.Rarity}; Rating: {averageRating:f2}");
}

//Class Plant
public class Plant
{
    public string PlantName { get; set; }
    public int Rarity { get; set; }
    public int Rating { get; set; }
    public int RatingsCount { get; set; }

    public Plant (string plantName, int rarity, int rating, int ratingsCount)
    {
        PlantName = plantName;
        Rarity = rarity;
        Rating = rating;
        RatingsCount = ratingsCount;
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
