//INPUT
int metersInput = int.Parse(Console.ReadLine());

//ACTION
double metersToKilometers = metersInput / 1000d;

//OUTPUT
Console.WriteLine($"{metersToKilometers:f2}");
