//INPUT
using System.Net.WebSockets;

double grade = double.Parse(Console.ReadLine());

//ACTIONS
if (grade >= 3.00)
{
    Console.WriteLine("Passed!");
}
else
{
    Console.WriteLine("Failed!");
}
