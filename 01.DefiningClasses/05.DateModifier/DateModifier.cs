
using System;

public class DateModifier
{
    public string FirstDate;
    public string SecondDate;

    public static int DifferenceBetween(string FirstDate, string SecondDate)
    {
        string[] firstSplit = FirstDate.Split();
        string[] secondSplit = SecondDate.Split();
        int difference = 0;
        DateTime first = new DateTime(int.Parse(firstSplit[0]),
            int.Parse(firstSplit[1]),
            int.Parse(firstSplit[2]));
        DateTime second = new DateTime(int.Parse(secondSplit[0]),
            int.Parse(secondSplit[1]),
            int.Parse(secondSplit[2]));
        difference = first.Subtract(second).Days;
        if (difference < 0)
        {
            difference *= -1;
        }

        return difference;
    }
}

