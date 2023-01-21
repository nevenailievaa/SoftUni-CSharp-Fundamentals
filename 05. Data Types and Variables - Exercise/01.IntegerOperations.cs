//INPUT
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
int n4 = int.Parse(Console.ReadLine());

//ACTION
long n1AndN2Sum = (long)(n1 + n2);
long divideN1AndN2 = (long)(n1AndN2Sum / n3);
long multiplyTheResult = (long)(divideN1AndN2 * n4);

//OUTPUT
Console.WriteLine(multiplyTheResult);
