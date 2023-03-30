//INPUT
int carsCount = int.Parse(Console.ReadLine());

//ACTION
List<Car> carsList = new List<Car>();

for (int i = 0; i < carsCount; i++)
{
    string[] carsInfo = Console.ReadLine().Split("|");
    string carName = carsInfo[0];
    int mileage = int.Parse(carsInfo[1]);
    int fuel = int.Parse(carsInfo[2]);

    Car currentCar = new Car(carName, mileage, fuel);
    carsList.Add(currentCar);
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

        for (int i = 0; i < carsList.Count; i++)
        {
            if (carsList[i].Name == carName)
            {
                if (carsList[i].Fuel >= fuel)
                {
                    carsList[i].Mileage += distance;
                    carsList[i].Fuel -= fuel;
                    Console.WriteLine($"{carsList[i].Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    if (carsList[i].Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carsList[i].Name}!");
                        carsList.Remove(carsList[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Not enough fuel to make that ride");
                }
            }
        }
    }

    //Refuel Command
    else if (commandType == "Refuel")
    {
        string carName = commandArray[1];
        int fuel = int.Parse(commandArray[2]);

        for (int i = 0; i < carsList.Count; i++)
        {
            if (carsList[i].Name == carName)
            {
                int currentFuel = carsList[i].Fuel;
                if (currentFuel + fuel > 75)
                {
                    int additionalFuel = 75 - currentFuel;
                    carsList[i].Fuel += additionalFuel;
                    Console.WriteLine($"{carsList[i].Name} refueled with {additionalFuel} liters");
                }
                else
                {
                    carsList[i].Fuel += fuel;
                    Console.WriteLine($"{carsList[i].Name} refueled with {fuel} liters");
                }
            }
        }
    }

    //Revert Command
    else if (commandType == "Revert")
    {
        string carName = commandArray[1];
        int kilometers = int.Parse(commandArray[2]); //25000 - 20000   10000

        for (int i = 0; i < carsList.Count; i++)
        {
            if (carsList[i].Name == carName)
            {
                int currentMileage = carsList[i].Mileage;
                int remainingMileage = currentMileage - kilometers;

                if (remainingMileage < 10000)
                {
                    carsList[i].Mileage = 10000;
                }
                else
                {
                    carsList[i].Mileage -= kilometers;
                    Console.WriteLine($"{carsList[i].Name} mileage decreased by {currentMileage - remainingMileage} kilometers");
                }
            }
        }
    }
}

//OUTPUT
foreach (Car car in carsList)
{
    Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
}

//Class Car
public class Car
{
    public string Name { get; set; }
    public int Mileage { get; set; }
    public int Fuel { get; set; }

    public Car (string name, int mileage, int fuel)
    {
        Name = name;
        Mileage = mileage;
        Fuel = fuel;
    }
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
