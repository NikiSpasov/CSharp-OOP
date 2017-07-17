
using System;
using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;


    public string Name
    {
        get { return this.name; }
    }

    public IReadOnlyCollection<Person> FirstTeam
    {
       get { return this.firstTeam.AsReadOnly(); }
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return this.reserveTeam.AsReadOnly(); }
    }

    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public void AddPlayers(Person player)
    {
        if (player.Age < 40)
        {
           firstTeam.Add(player);
        }
        else
        {
            reserveTeam.Add(player);
        }
    }
}

