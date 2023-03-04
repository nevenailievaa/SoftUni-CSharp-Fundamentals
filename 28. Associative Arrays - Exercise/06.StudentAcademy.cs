//INPUT
using System.Xml.Linq;

int commandsCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, double> students = new Dictionary<string, double>();
Dictionary<string, double> studentsGrades = new Dictionary<string, double>();

for (int i = 0; i < commandsCount; i++)
{
    string studentName = Console.ReadLine();
    double studentGrade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(studentName))
    {
        studentsGrades.Add(studentName, 1);
        students.Add(studentName, studentGrade);
    }
    else
    {
        double gradesCount = studentsGrades[studentName] + 1;
        students[studentName] = (students[studentName] + studentGrade) / gradesCount;
    }
}

//OUTPUT
foreach (var student in students)
{
    if (student.Value >= 4.5)
    {
        Console.WriteLine($"{student.Key} -> {student.Value:f2}");
    }
}