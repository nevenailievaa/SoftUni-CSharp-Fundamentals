//INPUT
int peopleCount = int.Parse(Console.ReadLine());
int elevatorCapacity = int.Parse(Console.ReadLine());

//ACTION
if (elevatorCapacity % peopleCount == 0)
{
    Console.WriteLine(elevatorCapacity / peopleCount);
}
else if (peopleCount % elevatorCapacity == 0)
{
    Console.WriteLine(peopleCount / elevatorCapacity);
}
else
{
    Console.WriteLine(peopleCount / elevatorCapacity + 1);
}
