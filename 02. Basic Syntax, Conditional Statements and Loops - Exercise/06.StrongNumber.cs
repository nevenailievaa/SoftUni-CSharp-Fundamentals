//INPUT
int number = int.Parse(Console.ReadLine());
int numberCopy = number;

int sum = 1;
//ACTION

while (numberCopy > 0)
{
    int digit = numberCopy % 10;
    numberCopy = numberCopy / 10; //Връща цяло число
    int factorial = 1;

    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }

    sum += factorial;
}

if (sum == number)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
