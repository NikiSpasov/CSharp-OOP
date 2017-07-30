using System.Collections.Generic;

public class Room
{
    private bool containsPet;
    private int number;
    private Pet petInTheRoom;

    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public Room(int num)
    {
        this.Number = num;
        this.containsPet = false;
    }

    public bool ContainsPet
    {
        get => this.containsPet;
        set => this.containsPet = value;
    }

    public Pet PetInTheRoom
    {
        get => this.petInTheRoom;
        set => this.petInTheRoom = value;
    }
}

