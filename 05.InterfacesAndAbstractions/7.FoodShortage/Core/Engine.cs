using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    public void Run()
    {
        Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            IBuyer currentBuyer;
            string[] cmdArgs = Console.ReadLine().Split(new[] { ' ' });

            if (cmdArgs.Length == 3)
            {
                currentBuyer = new Rebel(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                buyers.Add(cmdArgs[0], currentBuyer);
                continue;
            }
            currentBuyer = new Citizen(cmdArgs[0], int.Parse(cmdArgs[1]),
                cmdArgs[2], cmdArgs[3]);

            buyers.Add(cmdArgs[0], currentBuyer);
        }

        string nameToSearch = Console.ReadLine();

        while (nameToSearch != "End")
        {
            if (!buyers.ContainsKey(nameToSearch))
            {
                nameToSearch = Console.ReadLine();
                continue;
            }
            buyers[nameToSearch].BuyFood();
            nameToSearch = Console.ReadLine();
        }

        Console.WriteLine(buyers.Sum(x => x.Value.Food));
    }

}