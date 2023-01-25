//INPUT
int[] numbers = new int[int.Parse(Console.ReadLine())];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

//OUTPUT
for (int j = numbers.Length - 1; j >= 0; j--)
{
    Console.Write($"{numbers[j]} ");
}
