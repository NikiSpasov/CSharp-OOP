using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        List<Person> persons = new List<Person>();
        string input = Console.ReadLine();
        while (input != "END")
        {
            string[] cmdArgs = input.Split(' ');
            Person currentPerson = new Person(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
            persons.Add(currentPerson);
            input = Console.ReadLine();
        }
        int num = int.Parse(Console.ReadLine());
        var persontoCompare = persons[num - 1];
        int total = persons.Count;
        persons.RemoveAt(num - 1);
        int equal = 1;
        int notEqual = 0;
        foreach (var person in persons)
        {
            int result = persontoCompare.CompareTo(person);
            if (result == 0)
            {
                equal++;
                continue;
            }
            notEqual++;
        }
        if (equal == 1)
        {
            Console.WriteLine("No matches");
            return;
        }
        Console.WriteLine($"{equal} {total - equal} {total}");
    }
}