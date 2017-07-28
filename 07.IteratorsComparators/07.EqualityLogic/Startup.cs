using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<Person> personsHash = new HashSet<Person>(new Person.GetThisHash());
        SortedSet <Person> personSorted = new SortedSet<Person>(new Person.ComprarePerson());

        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split();
            var currentPerson = new Person(args[0], int.Parse(args[1]));
            personsHash.Add(currentPerson);
            personSorted.Add(currentPerson);
        }
        Console.WriteLine(personSorted.Count);
        Console.WriteLine(personsHash.Count);
    }
}

