//INPUT
string info = string.Empty;

//ACTION
Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

while ((info = Console.ReadLine()) != "end")
{
    string[] courseInfoArray = info.Split(" : ").ToArray();
    string courseName = courseInfoArray[0];
    string student = courseInfoArray[1];

    if (!courses.ContainsKey(courseName))
    {
        List<string> studentsArray = new List<string>();
        studentsArray.Add(student);
        courses.Add(courseName, studentsArray);
    }
    else
    {
        courses[courseName].Add(student);
    }
}

//OUTPUT
foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");

    for (int i = 0; i < course.Value.Count; i++)
    {
        Console.WriteLine($"-- {course.Value[i]}");
    }
}