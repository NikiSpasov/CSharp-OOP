using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> members = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] persons = Console.ReadLine()
                .Trim()
                .Split(new []{' ', ',', '\n', '\t', '\r'}, 
                StringSplitOptions.RemoveEmptyEntries);
            string name = persons[0];
            int age = int.Parse(persons[1]);
            Family.AddMember(new Person(name, age));
        }
        List<Person> above30 = Family.FamiliMembers.Where(x => x.age > 30).OrderBy(x => x.name).ToList();
        foreach (var person in above30)
        {
            Console.WriteLine($"{person.name} - {person.age}");
        }
    }
}

