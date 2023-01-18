//INPUT
using System.Diagnostics;

int ordersCnt = int.Parse(Console.ReadLine());

//CHANGEABLE
double pricePerCapsule = 0;
int days = 0;
int capsulesCnt = 0;

double priceForTheCoffee = 0;
double total = 0;

//ACTION
for (int i = 1; i <= ordersCnt; i++)
{
    pricePerCapsule = double.Parse(Console.ReadLine());
    days = int.Parse(Console.ReadLine());
    capsulesCnt = int.Parse(Console.ReadLine());

    priceForTheCoffee = (pricePerCapsule * days) * capsulesCnt;
    total += priceForTheCoffee;
    Console.WriteLine($"The price for the coffee is: ${priceForTheCoffee:f2}");
}

//OUTPUT
Console.WriteLine($"Total: ${total:f2}");
