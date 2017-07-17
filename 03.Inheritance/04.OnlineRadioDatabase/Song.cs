
using System;

public class Song
{
    protected Artist artist;
    protected TimeSpan length;
    protected string name;
    private const int minMinute = 0;
    private const int maxMinute = 14;
    private const int minSec = 0;
    private const int maxSec = 59;
    public Artist Artist
    {
        get
        {
            return this.artist;
        }
        set { this.artist = value; }
    }

    public TimeSpan Length
    {
        get { return this.length; }
        set
        {
            this.length = value;
        }
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length > 30 || value.Length < 3)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            this.name = value;
        }
    }

    public TimeSpan GetMinutesAndSeconds(int minutes, int seconds)
    {
        if (minutes < minMinute || minutes > maxMinute)
        {
            throw new ArgumentException("Song minutes should be between 0 and 14.");
        }
        if (seconds < minSec || seconds > maxSec)
        {
            throw new ArgumentException("Song seconds should be between 0 and 59.");
        }
        return new TimeSpan(0, minutes, seconds);
    }

    public Song(Artist artist, string name)
    {
        Artist = artist;
        Name = name;
    }
}
