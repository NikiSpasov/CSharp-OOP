
    using System;
    using System.Text.RegularExpressions;

public class Student : Human
    {
    private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
        :base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length > 10 || value.Length < 5)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            Regex digitsAndLetters = new Regex(@"^[\w\d]{5,10}$");
            bool match = digitsAndLetters.IsMatch(value);
            if (match)
            {
            this.facultyNumber = value;
            }
            else
            {
            throw new ArgumentException("Invalid faculty number!");
            }
        }
    }

        public override string ToString()
        {
            return $"First Name: {base.FirstName}{Environment.NewLine}Last Name: {base.LastName}{Environment.NewLine}" +
                   $"Faculty number: {this.FacultyNumber}{Environment.NewLine}";
        }
    }

