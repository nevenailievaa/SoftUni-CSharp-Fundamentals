//INPUT
double budget = double.Parse(Console.ReadLine());
int signedStudentsCount = int.Parse(Console.ReadLine());

//Prices
double packOfFlourPrice = double.Parse(Console.ReadLine());
double eggPrice = double.Parse(Console.ReadLine());
double apronPrice = double.Parse(Console.ReadLine());

//ACTION
double sum = 0;
int floursCount = signedStudentsCount - (signedStudentsCount / 5);
int eggsCount = signedStudentsCount * 10;
double apronsCount = signedStudentsCount + Math.Ceiling((double)signedStudentsCount * 0.2);

sum = (apronPrice * apronsCount) + (eggPrice * eggsCount) + (packOfFlourPrice * floursCount);

//OUTPUT
if (sum <= budget)
{
    Console.WriteLine($"Items purchased for {sum:f2}$.");
}
else
{
    Console.WriteLine($"{sum - budget:f2}$ more needed.");
}