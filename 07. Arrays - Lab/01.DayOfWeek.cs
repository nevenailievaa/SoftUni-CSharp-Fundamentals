//INPUT
int dayNumber = int.Parse(Console.ReadLine());

//ACTION
string[] daysOfTheWeek =
{
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

dayNumber--;

if (dayNumber >= 0 && dayNumber <= 6)
{
    Console.WriteLine(daysOfTheWeek[dayNumber]);
}
else
{
    Console.WriteLine("Invalid day!");
}
