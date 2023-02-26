//INPUT
using System.Diagnostics;

string info = string.Empty;

//ACTION
List<Vehicle> vehiclesList = new List<Vehicle>();

while ((info = Console.ReadLine()) != "End")
{
    string[] infoArray = info.Split();
    string type = infoArray[0];
    string model = infoArray[1];
    string color = infoArray[2];
    int horsePower = int.Parse(infoArray[3]);

    Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);
    vehiclesList.Add(currentVehicle);
}

//OUTPUT
//Vehicle Info
string command = string.Empty;
while((command = Console.ReadLine()) != "Close the Catalogue")
{
    string inputInfo = command;

    foreach (Vehicle vehicle in vehiclesList)
    {
        if (inputInfo == vehicle.Model)
        {
            Console.WriteLine(vehicle);
        }
    }
}

//Vehicles and Trucks Average Horsepower
List<Vehicle> carsList = new List <Vehicle>();
foreach (Vehicle currVehicle in vehiclesList)
{
    if (currVehicle.Type == "car")
    {
        carsList.Add(currVehicle);
    }
}

List<Vehicle> trucksList = new List<Vehicle>();
foreach (Vehicle currVehicle in vehiclesList)
{
    if (currVehicle.Type == "truck")
    {
        trucksList.Add(currVehicle);
    }
}

//Average Horse Powers
int carsHorsePowerSum = 0;
for (int i = 0; i < carsList.Count; i++)
{
    carsHorsePowerSum += carsList[i].HorsePower;
}

int trucksHorsePowerSum = 0;
for (int i = 0; i < trucksList.Count; i++)
{
    trucksHorsePowerSum += trucksList[i].HorsePower;
}

double carsAverageHorsePwr = (double)carsHorsePowerSum / carsList.Count;
double trucksAverageHorsePwr = (double)trucksHorsePowerSum / trucksList.Count;

//OUTPUT
//Zeroes Checker
if (trucksList.Count == 0 && carsList.Count == 0)
{
    Console.WriteLine($"Cars have average horsepower of: 0.00.");
    Console.WriteLine($"Trucks have average horsepower of: 0.00.");
}
else if (carsList.Count == 0)
{
    Console.WriteLine($"Cars have average horsepower of: 0.00.");
    Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePwr:f2}.");
}
else if (trucksList.Count == 0)
{
    Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePwr:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: 0.00.");
}
else
{
    Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePwr:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePwr:f2}.");
}

//Vehicle Class
public class Vehicle
{
    public Vehicle(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public override string ToString()
    {
        if (this.Type == "car")
        {
            return $"Type: Car\r\n Model: {this.Model}\r\n Color: {this.Color}\r\n Horsepower: {this.HorsePower}";
        }
        else
        {
            return $"Type: Truck\r\n Model: {this.Model}\r\n Color: {this.Color}\r\n Horsepower: {this.HorsePower}";
        }
    }

    public string Type {get; set;}
    public string Model {get; set; }
    public string Color {get; set; }
    public int HorsePower {get; set; }
}
