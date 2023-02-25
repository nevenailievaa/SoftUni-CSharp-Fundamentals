//INPUT
int studentsCount = int.Parse(Console.ReadLine());

//ACTION
List<Students> studentsList = new List<Students>();

for (int i = 1; i <= studentsCount; i++)
{
    string[] studentInfoArray = Console.ReadLine().Split();

    string firstName = studentInfoArray[0];
    string lastName = studentInfoArray[1];
    double grade = double.Parse(studentInfoArray[2]);

    studentsList.Add(new Students(firstName, lastName, grade));
}

//OUTPUT
foreach (Students currentStudent in studentsList.OrderByDescending(x => x.Grade))
{
    Console.WriteLine(currentStudent);
}

//Students Class
public class Students
{
    public Students(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    //Return Value
    public override string ToString()
    {
        return ($"{this.FirstName} {this.LastName}: {Grade:f2}");
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}