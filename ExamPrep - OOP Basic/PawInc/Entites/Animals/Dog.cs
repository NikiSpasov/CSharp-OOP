public class Dog : Animal
{
    private int commands;

    public Dog(string name, int age, int commands) : base(name, age)
    {
        this.Commands = commands;
    }

    public int Commands
    {
        get => this.commands;
        private set => this.commands = value;
    }
}

