
using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        Team team = new Team("MyTeam");


        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                cmdArgs[1],
                int.Parse(cmdArgs[2]),
                double.Parse(cmdArgs[3]));

            team.AddPlayers(person);
        }
        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}

