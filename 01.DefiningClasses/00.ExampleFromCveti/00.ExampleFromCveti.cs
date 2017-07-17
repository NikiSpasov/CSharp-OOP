using System;

public class Human
{
    public string Name { get; set; }
    private DateTime birthDate;


    public DateTime BirthDate
    {
        get
        {
            return birthDate;
        }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException();
            }

            birthDate = value;
        }
    }

    public int Age => DateTime.Now.Year - BirthDate.Year - (DateTime.Now.DayOfYear < BirthDate.DayOfYear ? 1 : 0);

    public Human(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

}