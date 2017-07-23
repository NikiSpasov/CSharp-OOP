using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, IPrivate, ISoldier, ILeutenantGeneral
{
    public IList<ISoldier> Soldiers { get; }

    public LeutenantGeneral(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        Soldiers = new List<ISoldier>();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{Environment.NewLine}Privates:");
        foreach (var prvt in Soldiers)
        {
            sb.AppendLine($"  {prvt.ToString()}");
        }
        return sb.ToString().Trim();
    }
}

