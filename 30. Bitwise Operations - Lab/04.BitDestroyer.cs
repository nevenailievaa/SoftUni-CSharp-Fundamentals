//INPUT
int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

//ACTION
int mask = ~(1 << p);

//OUTPUT
Console.WriteLine(n & mask);