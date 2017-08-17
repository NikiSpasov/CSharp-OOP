using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _04.WorkForce;

public class StratUp
{
    public static void Main()
    {
        JobsList jobs = new JobsList();   
        List<BaseEmploee> employees = new List<BaseEmploee>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] args = input.Split();
            switch (args[0])
            {
                case "Job":
                    Job job = new Job(args[1], int.Parse(args[2]), employees.First(e => e.Name == args[3]));
                    jobs.Add(job);
                    break;
                case "StandartBaseEmploee":
                    BaseEmploee standartBaseEmploee = new StandartBaseEmploee(args[1]);
                    employees.Add(standartBaseEmploee);
                    break;
                case "PartTimeBaseEmploee":
                    BaseEmploee parttimeBaseEmploee = new PartTimeBaseEmploee(args[1]);
                    employees.Add(parttimeBaseEmploee);
                    break;
                case "Pass":
                    foreach (var jobInProgress in jobs)
                    {
                        jobInProgress.Update();
                    }
                    break;
                case "Status":
                    foreach (var jobb in jobs)
                    {
                        Console.WriteLine(jobb.ToString());
                    }
                    break;
                  
            }
            input = Console.ReadLine();
        }
    }
}
