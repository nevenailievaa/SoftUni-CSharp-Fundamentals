//ACTION
string command = String.Empty;
List<Student> students = new List<Student>();

//INPUT
while ((command = Console.ReadLine()) != "end") 
{
    string[] studentInfoArray = command.Split();
    Student currentStudent = new Student();

    currentStudent.FirstName = studentInfoArray[0];
    currentStudent.LastName = studentInfoArray[1];
    currentStudent.Age = int.Parse(studentInfoArray[2]);
    currentStudent.HomeTown = studentInfoArray[3];

    students.Add(currentStudent);
}

//OUTPUT
string outputCity = Console.ReadLine();

foreach (Student currentStudent in students)
{
    if (currentStudent.HomeTown == outputCity)
    {
        Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
    }
}

//STUDENT CLASS
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}