using System;
using System.Text;

public class Spy : Soldier, ISpy
{
    public int CodeNumber { get; }

    public Spy(int id, string firstName, string lastName, int codeNumber)
        : base(firstName, lastName, id)
    {
        CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{Environment.NewLine}Code Number: {CodeNumber}");
        return sb.ToString().Trim();
    }
}

