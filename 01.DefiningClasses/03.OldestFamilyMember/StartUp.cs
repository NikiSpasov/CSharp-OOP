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
        Person theOldest = Family.GetOldestMember(Family.FamiliMembers);
        
        Console.WriteLine($"{theOldest.name} {theOldest.age}");


        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }
    }
}

