//INPUT
int inputNum = int.Parse(Console.ReadLine());
int position = int.Parse(Console.ReadLine());

//ACTION
int secondNum = inputNum >> position;

//OUTPUT
Console.WriteLine(secondNum & position);