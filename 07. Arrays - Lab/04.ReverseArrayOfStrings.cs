//INPUT
string[] digits = Console.ReadLine().Split();

//ACTION
string[] digitsReversed = digits.Reverse().ToArray();

//OUTPUT
for (int i = 0; i < digits.Length; i++)
{
    Console.Write($"{digitsReversed[i]} ");
}
