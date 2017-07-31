using System;
using System.Runtime.Remoting.Messaging;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay => this.weekDay;

    public string Notes { get; private set; }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        int dayCompare = this.WeekDay.CompareTo(other.WeekDay);
        int notesCompare = this.Notes.CompareTo(other.Notes);
       
        if (dayCompare != 0)
        {
            return dayCompare;
        }
        if (notesCompare != 0)
        {
            return notesCompare;
        }
        return 0;
    }
}

