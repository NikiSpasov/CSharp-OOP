using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, ISoldier, IPrivate, IEngineer, ISpecialisedSoldier
{
    public IDictionary<string, int> Repairs { get; }

    public Engineer(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        Repairs = new Dictionary<string, int>();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{Environment.NewLine}Repairs:");
        foreach (var repair in Repairs)
        {
            sb.AppendLine($"  Part Name: {repair.Key} Hours Worked: {repair.Value}");
        }
        return sb.ToString().Trim();
    }
}

