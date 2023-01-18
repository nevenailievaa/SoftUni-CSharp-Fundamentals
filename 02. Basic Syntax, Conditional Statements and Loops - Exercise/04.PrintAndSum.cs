//INPUT
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

//CHANGEABLE
int sum = 0;

//ACTION
for (int i = n1; i <= n2; i++)
{
    sum += i;
    Console.Write($"{i} ");
}

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
