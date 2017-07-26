public class Pet : IBreathable
{
    private string birthDate;

    public Pet(string type, string name, string birthDate)
    {
        Name = name;
        Birthdate = birthDate;
        Type = type;
    }

    public string Id { get; set; }
    public string Type { get; set; }

    public string Birthdate
    {
        get { return this.birthDate; }
        set { this.birthDate = value; }
    }

    public string Name { get; }
}


