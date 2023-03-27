//INPUT
int input = int.Parse(Console.ReadLine());

//OUTPUT
Console.WriteLine(GetFibonacci(input));

static int GetFibonacci(int n)
{
    if (n == 2 || n == 1)
    {
        return 1;
    }

    int number = GetFibonacci(n - 1) + GetFibonacci(n - 2);
    return number;
}