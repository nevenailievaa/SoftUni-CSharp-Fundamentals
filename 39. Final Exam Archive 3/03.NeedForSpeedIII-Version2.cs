//INPUT
int carsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, int> carAndMileage = new Dictionary<string, int>();
Dictionary<string, int> carAndFuel = new Dictionary<string, int>();

for (int i = 0; i < carsCount; i++)
{
    string[] carInfo = Console.ReadLine().Split("|");
    string carName = carInfo[0];
    int mileage = int.Parse(carInfo[1]);
    int fuel = int.Parse(carInfo[2]);

    carAndMileage.Add(carName, mileage);
    carAndFuel.Add(carName, fuel);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "Stop")
{
    string[] commandArray = command.Split(" : ");
    string commandType = commandArray[0];

    //Drive Command
    if (commandType == "Drive")
    {
        string carName = commandArray[1];
        int distance = int.Parse(commandArray[2]);
        int fuel = int.Parse(commandArray[3]);

        if (carAndFuel[carName] - fuel >= 0)
        {
            carAndMileage[carName] += distance;
            carAndFuel[carName] -= fuel;
            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        if (carAndMileage[carName] >= 100000)
        {
            Console.WriteLine($"Time to sell the {carName}!");
            carAndMileage.Remove(carName);
            carAndFuel.Remove(carName);
        }
    }

    //Refuel Command
    else if (commandType == "Refuel")
    {
        string carName = commandArray[1];
        int fuel = int.Parse(commandArray[2]); //60 + 20 = 80    15

        int currentFuel = carAndFuel[carName];
        int addedFuel = 0;

        if (carAndFuel[carName] + fuel > 75)
        {
            carAndFuel[carName] = 75;
            addedFuel = 75 - currentFuel;
        }
        else
        {
            addedFuel = fuel;
            carAndFuel[carName] += fuel;
        }
        Console.WriteLine($"{carName} refueled with {addedFuel} liters");
    }

    //Revert Command
    else if (commandType == "Revert")
    {
        string carName = commandArray[1];
        int kilometers = int.Parse(commandArray[2]);

        if (carAndMileage[carName] - kilometers < 10000)
        {
            carAndMileage[carName] = 10000;
        }
        else
        {
            carAndMileage[carName] -= kilometers;
            Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
        }
    }
}

//OUTPUT
foreach (var car in carAndMileage)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carAndFuel[car.Key]} lt.");
}

//You have just bought the latest and greatest computer game – Need for Seed III.
//Pick your favorite cars and drive them all you want! We know that you can't wait
//to start playing.

//On the first line of the standard input, you will receive an integer n – the number
//of cars that you can obtain. On the next n lines, the cars themselves will follow
//with their mileage and fuel available, separated by "|" in the following format:
//"{car}|{mileage}|{fuel}"

//Then, you will be receiving different commands, each on a new line, separated by
//" : ", until the "Stop" command is given:

//- "Drive : {car} : {distance} : {fuel}":
//You need to drive the given distance, and you will need the given fuel to do that.
//If the car doesn't have enough fuel, print: "Not enough fuel to make that ride"
//If the car has the required fuel available in the tank, increase its mileage with
//the given distance, decrease its fuel with the given fuel, and print: 
//"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
//You like driving new cars only, so if a car's mileage reaches 100 000 km, remove it
//from the collection(s) and print: "Time to sell the {car}!"

//- "Refuel : {car} : {fuel}":
//Refill the tank of your car. 
//Each tank can hold a maximum of 75 liters of fuel, so if the given amount of fuel
//is more than you can fit in the tank, take only what is required to fill it up. 
//Print a message in the following format: "{car} refueled with {fuel} liters"

//- "Revert : {car} : {kilometers}":
//Decrease the mileage of the given car with the given kilometers and print the
//kilometers you have decreased it with in the following format:
//"{car} mileage decreased by {amount reverted} kilometers"
//If the mileage becomes less than 10 000km after it is decreased, just set it to
//10 000km and DO NOT print anything.

//Upon receiving the "Stop" command, you need to print all cars in your possession
//in the following format:
//"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
