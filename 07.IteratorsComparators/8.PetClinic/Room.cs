using System.Runtime.Remoting.Messaging;

public class Room
{
    private bool containsPet;

    public bool ContainsPet
    {
        get => this.containsPet;
        set => this.containsPet = value;
    }
}

