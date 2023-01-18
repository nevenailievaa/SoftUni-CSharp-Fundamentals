//INPUT
string studentName = Console.ReadLine();
int studentAge = int.Parse(Console.ReadLine());
double averageGrade = double.Parse(Console.ReadLine());

//OUTPUT
Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {averageGrade:f2}");