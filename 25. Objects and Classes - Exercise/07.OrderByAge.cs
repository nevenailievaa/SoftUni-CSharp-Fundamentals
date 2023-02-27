//INPUT
string info = string.Empty;

//ACTION
List<Student> studentsList = new List<Student>();

while ((info = Console.ReadLine()) != "End")
{
    string[] studentInfo = info.Split();

    string name = studentInfo[0];
    string studentId = studentInfo[1];
    int age = int.Parse(studentInfo[2]);

    Student currentStudent = new Student(name, studentId, age);

    //Already Used ID Checker
    bool alreadyAnId = false;
    for (int i = 0; i < studentsList.Count; i++)
    {
        if (studentsList[i].StudentID == currentStudent.StudentID)
        {
            studentsList[i].Name = currentStudent.Name;
            studentsList[i].Age = currentStudent.Age;
            alreadyAnId = true;
        }
    }

    if (!alreadyAnId)
    {
        studentsList.Add(currentStudent);
    }
}

//OUTPUT
foreach (Student student in studentsList.OrderBy(s => s.Age))
{
    Console.WriteLine($"{student.Name} with ID: {student.StudentID} is {student.Age} years old.");
}

//STUDENT CLASS
public class Student
{
    public Student (string name, string studentId, int age)
    {
        Name = name;
        StudentID = studentId;
        Age = age;
    }
    public string Name { get; set; }
    public string StudentID { get; set; }
    public int Age { get; set; }
}