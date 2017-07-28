using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        SortedSet<Person> byName = new SortedSet<Person>(new Person.NameLenght());
        SortedSet<Person> byAge = new SortedSet<Person>(new Person.Years());

        Person currentPerson = null;
        for (int i = 0; i < num; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split(' ');
            currentPerson = new Person(cmdArgs[0], int.Parse(cmdArgs[1]));
            byAge.Add(currentPerson);
            byName.Add(currentPerson);
        }
        foreach (var person in byName)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }
        foreach (var person in byAge)
        {

            Console.WriteLine($"{person.Name} {person.Age}");

        }

    }
}

