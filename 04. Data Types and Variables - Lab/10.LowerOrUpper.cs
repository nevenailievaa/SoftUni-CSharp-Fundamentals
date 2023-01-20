//INPUT
char inputSymbol = char.Parse(Console.ReadLine());

if (inputSymbol >= 64 && inputSymbol <= 90)
{
    Console.WriteLine("upper-case");
}
else
{
    Console.WriteLine("lower-case");
}