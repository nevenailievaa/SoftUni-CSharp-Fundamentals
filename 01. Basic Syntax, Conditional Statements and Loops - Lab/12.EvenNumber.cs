//INPUT
int number = int.Parse(Console.ReadLine());

while (number % 2 == 1 || number % 2 == -1)
{
    Console.WriteLine("Please write an even number.");
    number = int.Parse(Console.ReadLine());
}

//FINAL OUTPUT
Console.WriteLine($"The number is: {Math.Abs(number)}");
