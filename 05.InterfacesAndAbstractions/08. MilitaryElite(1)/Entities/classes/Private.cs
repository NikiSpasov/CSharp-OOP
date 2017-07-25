using System.Text;

public class Private : Soldier, IPrivate
{
    public double Salary { get; }

    public Private(int id, string firstName, string lastName, double salary) :
        base (firstName, lastName, id)
    {
        Salary = salary;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($" Salary: {Salary:F2}");
        return sb.ToString().Trim();
    }
}

