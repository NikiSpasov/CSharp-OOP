public abstract class Animal
{
    private string name;
    private int age;
    private bool cleansingStatus;

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.CleansingStatus = false;
    }

    public string Name
    {
        get => name;
        private set => name = value;
    }
    public int Age
    {
        get => age;
        private set => age = value;
    }
    public bool CleansingStatus
    {
        get => cleansingStatus;
        set => cleansingStatus = value;
    }
}
