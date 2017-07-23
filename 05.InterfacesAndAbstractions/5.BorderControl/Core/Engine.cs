using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    public void Run()
    {
        ICollection<IBreathable> creatures = new List<IBreathable>();
        IBreathable currentCreature = null;
        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] cmdArgs = input.Split(new[] { ' ' });
            string type = cmdArgs[0];

            switch (type)
            {
            case "Citizen":
                    currentCreature = new Citizen(type, cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
                    break;
                case "Pet":
                    currentCreature = new Pet(type, cmdArgs[1], cmdArgs[2]);

                    break;
                case "Robot":
                    input = Console.ReadLine();
                    continue;
            }

            creatures.Add(currentCreature);

            input = Console.ReadLine();

        }
        string searchedYear = Console.ReadLine();

        foreach (var creature in creatures
            .Where(x => x.Birthdate.Split('/').Last() == searchedYear)) 
        {
            Console.WriteLine(creature.Birthdate);
        }  
    }
}