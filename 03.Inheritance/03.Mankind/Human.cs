
using System;
using System.Dynamic;

public class Human
{
    protected string firstName;
    protected string lastName;


    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            firstName = value;
            
            
            
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
            
        }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            this.lastName = value;
        }
    }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

}

