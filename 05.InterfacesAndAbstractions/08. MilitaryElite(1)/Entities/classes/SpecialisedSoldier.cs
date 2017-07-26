using System.Text;
using System;

public abstract class SpecialisedSoldier : Private, IPrivate, ISoldier, ISpecialisedSoldier
{
    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string coprs)
        :base (id, firstName, lastName, salary)
    {
        Corps = coprs;
    }

    public string Corps { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{Environment.NewLine}Corps: {Corps}");
        return sb.ToString().Trim();
    }
}

