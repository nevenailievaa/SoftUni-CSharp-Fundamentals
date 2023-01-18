//INPUT
using System;

string countryName = Console.ReadLine();

//ACTIONS
if (countryName == "USA" || countryName == "England")
{
    Console.WriteLine("English");
}
else if (countryName == "Spain" || countryName == "Argentina" || countryName == "Mexico")
{
    Console.WriteLine("Spanish");
}
else
{
    Console.WriteLine("unknown");
}