public class Private : Soldier, IPrivate
{
    public double Salary { get; }

    public Private(string firstName, string lastName, int id, double salary) :
        base (firstName, lastName, id)
    {
        Salary = salary;
    }

    public override string ToString()
    {
        return base.ToString() + $"Salary {Salary:F2}";
    }
}

