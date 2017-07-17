using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int numberOfBadges;
    private List<Pokemon> pokemons;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int NumberOfBadges
    {
        get { return this.numberOfBadges; }
        set { this.numberOfBadges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }
    public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
    {
        NumberOfBadges = 0;
        Name = name;
        NumberOfBadges = numberOfBadges;
        Pokemons = pokemons;
    }
}
