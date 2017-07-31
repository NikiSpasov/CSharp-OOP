using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

public class SoldierFactory
{

    public List<Soldier> Soldiers;

    public SoldierFactory()
    {
        Soldiers = new List<Soldier>();
    }
    public void CreateSoldier(string type, List<string> cmdArgs)
    {
        int id = int.Parse(cmdArgs[0]);
        string firstName = cmdArgs[1];
        string lastName = cmdArgs[2];
        double salary = 0;
        if (type != "Spy")
        {
            salary = double.Parse(cmdArgs[3]);
        }
        switch (type)
        {              
            case "Private":
                var prvt = new Private(id, firstName, lastName, salary);
                Soldiers.Add(prvt);
                break;

            case "Commando":
                string corps = cmdArgs[4];
                if (corps != "Airforces" && corps != "Marines")
                {
                    break;
                }
                var commando = new Commando(id, firstName, lastName, salary, corps);
                for (int i = 5; i < cmdArgs.Count - 1; i+=2)
                {
                    if (cmdArgs[i + 1] != "inProgress" && cmdArgs[i + 1] != "Finished")
                    {
                        continue;
                    }
                    commando.Missions.Add(cmdArgs[i], cmdArgs[i + 1]);
                }
                Soldiers.Add(commando);
                break;

            case "LeutenantGeneral":
                var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
                for (int i = 4; i < cmdArgs.Count; i++)
                {
                    leutenantGeneral.Soldiers.Add(Soldiers.Where(x => x.Id == int.Parse(cmdArgs[i])).First());
                }
                Soldiers.Add(leutenantGeneral);
                break;

            case "Engineer":
                corps = cmdArgs[4];
                if (corps != "Airforces" && corps != "Marines")
                {
                    break;//WATCH THIS!!!!!!!
                }
                var engineer = new Engineer(id, firstName, lastName, salary, corps);
                for (int i = 5; i < cmdArgs.Count - 1; i+=2)
                {
                    engineer.Repairs.Add(cmdArgs[i], int.Parse(cmdArgs[i + 1]));
                }
                Soldiers.Add(engineer);
                break;
            case "Spy":
                var spy = new Spy(id, firstName, lastName, int.Parse(cmdArgs[3]));
                Soldiers.Add(spy);
                break;
        }

    }
    public void PrintResult()
    {
        foreach (var soldier in Soldiers)
        {
            Console.WriteLine(soldier.ToString());
        }
    }
}

