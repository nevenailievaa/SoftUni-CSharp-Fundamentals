using System;
using System.Collections.Generic;
using System.Linq;

//INPUT
int numberOfMembers = int.Parse(Console.ReadLine());

//ACTION
Family thisFamily = new Family();

for (int i = 0; i < numberOfMembers; i++)
{
    string[] input = Console.ReadLine().Split();
    thisFamily.AddMember(input[0], int.Parse(input[1]));
}

//OUTPUT
Person oldestMember = thisFamily.GetOldestMember();
Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

//PERSON CLASS
public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person()
    {
        this.Name = "No Name";
        this.Age = 0;
    }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

//FAMILY CLASS
public class Family
{
    List<Person> People { get; set; }

    public void AddMember(string name, int age)
    {
        Person newMember = new Person(name, age);
        People.Add(newMember);
    }

    public Person GetOldestMember()
    {
        return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
    }

    public Family()
    {
        this.People = new List<Person>();
    }
}
