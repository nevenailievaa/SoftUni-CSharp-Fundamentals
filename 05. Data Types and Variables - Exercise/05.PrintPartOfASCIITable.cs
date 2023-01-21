//INPUT
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int currentChar = numberOne;

//OUTPUT
for (int i = numberOne; i <= numberTwo; i++)
{
    Console.Write($"{Convert.ToChar(currentChar)} ");
    currentChar++;
}
