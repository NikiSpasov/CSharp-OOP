using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
    {
        SoldierFactory soldierFactory = new SoldierFactory();
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> cmdArg = input.Split().ToList();
                string type = cmdArg[0];
                cmdArg.RemoveAt(0);
                soldierFactory.CreateSoldier(type, cmdArg);
                input = Console.ReadLine();
            }
            soldierFactory.PrintResult();

        }
    }

