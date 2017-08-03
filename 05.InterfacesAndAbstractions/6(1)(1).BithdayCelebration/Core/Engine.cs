using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Engine
{
    public void Run()
    {
        ICollection<IPeople> people = new List<IPeople>();
        IPeople intruder;
        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] cmdArgs = input.Split(new[] { ' ' });

            if (cmdArgs.Length < 3)
            {
              intruder = new Robot(cmdArgs[0], cmdArgs[1]);  
            }
            else
            {
                intruder = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
            }
            people.Add(intruder);

            input = Console.ReadLine();

        }
        string lastDigits = Console.ReadLine();
        Regex regex = new Regex($"{lastDigits}$");

        foreach (var person in people.Where(x => regex.IsMatch(x.Id)))
        {
            Console.WriteLine(person.Id);
        }

    }
}