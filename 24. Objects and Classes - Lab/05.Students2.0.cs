//ACTION
string command = String.Empty;
List<Student> studentsList = new List<Student>();

//INPUT
while ((command = Console.ReadLine()) != "end")
{
    string[] studentInfoArray = command.Split();

    string firstName = studentInfoArray[0];
    string lastName = studentInfoArray[1];
    int age = int.Parse(studentInfoArray[2]);
    string homeTown = studentInfoArray[3];

    bool studentExists = false;

    //Check
    foreach (var student in studentsList) 
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            studentExists = true;
            break;
        }
    }

    //Already Exists
    if (studentExists)
    {
        foreach (var student in studentsList)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                student.Age = age;
                student.HomeTown = homeTown;
            }
        }
    }

    //New
    else
    {
        Student student = new Student();
        student.FirstName = firstName;
        student.LastName = lastName;
        student.Age = age;
        student.HomeTown = homeTown;

        studentsList.Add(student);
    }
}


//OUTPUT
string outputCity = Console.ReadLine();

foreach (Student currentStudent in studentsList)
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