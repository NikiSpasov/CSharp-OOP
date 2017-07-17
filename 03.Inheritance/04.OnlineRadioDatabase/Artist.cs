
using System;

public class Artist
{
    private string name;
    private const int minLength = 3;
    private const int maxLength = 20;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length < minLength || value.Length > maxLength )
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            this.name = value;
        }
    }

    public Artist(string name)
    {
        Name = name;
    }
}

