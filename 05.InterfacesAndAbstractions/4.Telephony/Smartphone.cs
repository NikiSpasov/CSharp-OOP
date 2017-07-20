using System;
using System.Text.RegularExpressions;

public class Smartphone : IBrowseable, ICallable
{
    private string number;
    private string site;


    public string Number
    {
        get
        { return this.number; }
        private set
        {
        Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(value) || value == null)
            {
                throw new ArgumentException("Invalid number!");
            }
            this.number = value;
        }
    }

    public string Site
    {
        get { return this.site; }
        private set
        {
            Regex regex = new Regex(@"^\D+$");
                if (!regex.IsMatch(value) || value == null)
                {
                    throw  new ArgumentException("Invalid URL!");
                }
                this.site = value;
        }
    }

    public void Browse(string[] sites)
    {
        if (sites.Length < 1)
        {
            Console.WriteLine("Invalid URL!");
        }
        foreach (var site in sites)
        {
            try
            {
                this.Site = site;
                Console.WriteLine($"Browsing: {site}!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }       
    }

    public void Call(string[] numbers)
    {
        if (numbers.Length < 1)
        {
            Console.WriteLine("Invalid number!");
        }
        foreach (var number in numbers)
        {
            try
            {
                this.Number = number;
                Console.WriteLine($"Calling... {number}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   
    }
}

