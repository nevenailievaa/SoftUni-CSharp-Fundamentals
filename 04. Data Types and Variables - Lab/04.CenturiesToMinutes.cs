//INPUT
int centuries = int.Parse(Console.ReadLine());

//ACTION
int years = centuries * 100;
int days = (int)(years * 365.2422);
int hours = days * 24;
int minutes = hours * 60;

//OUTPUT
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
