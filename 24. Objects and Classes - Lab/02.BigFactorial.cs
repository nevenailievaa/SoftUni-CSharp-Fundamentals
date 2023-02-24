//INPUT
using System.Numerics;

int inputNumber = int.Parse(Console.ReadLine());

//ACTION
BigInteger sum = 1;

for (int i = inputNumber; i >= 1; i--)
{
    sum *= i;
}

//OUTPUT
Console.WriteLine(sum);