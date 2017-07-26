using System.Collections.Generic;
using System.Text;
using System;

public class Commando : SpecialisedSoldier, ICommando, ISoldier, IPrivate, ISpecialisedSoldier
{
    public IDictionary<string, string> Missions { get; }

    public Commando(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        Missions = new Dictionary<string, string>();
    }

    public void CompleteMission(string codeName)
    {
        Missions[codeName] = "Finished";
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.Append($"{Environment.NewLine}Missions:");
        foreach (var misson in Missions)
        {
            sb.Append($"{Environment.NewLine}  Code Name: {misson.Key} State: {misson.Value}");
        }
        return sb.ToString().Trim();
    } 
}
