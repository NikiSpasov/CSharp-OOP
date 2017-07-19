using System;

public class Ferrari : ICar
{

    private string make;
    private string model;
    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
        this.Make = "Ferrari";
    }


    public string Make
    {
        get { return this.make; }
        private set { this.make = value; }
    }

    public string Model
    {
        get { return this.model; }
        private set { this.model = value; }
    }

    public string Driver
    {
        get { return this.driver; }
        private set { this.driver = value; }
    }


    public string UseBreaks()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }
    }

