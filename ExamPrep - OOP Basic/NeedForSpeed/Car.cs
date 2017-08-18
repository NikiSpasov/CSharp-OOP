
using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;
    public int Stars;
    public List<string> AddOns;

    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration,
        int suspension, int durability)
    {
        Brand = brand;
        Model = model;
        YearOfProduction = yearOfProduction;
        Horsepower = horsepower;
        Acceleration = acceleration;
        Suspension = suspension;
        Durability = durability;
    }
    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration,
        int suspension, int durability, int stars)
    {
        Brand = brand;
        Model = model;
        YearOfProduction = yearOfProduction;
        Horsepower = horsepower;
        Acceleration = acceleration;
        Suspension = suspension;
        Durability = durability;
        Stars = stars;
    }
    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration,
        int suspension, int durability, List<string> addOns)
    {
        Brand = brand;
        Model = model;
        YearOfProduction = yearOfProduction;
        Horsepower = horsepower;
        Acceleration = acceleration;
        Suspension = suspension;
        Durability = durability;
        AddOns = addOns;
    }

    public Car()
    {

    }

    public int Durability
    {
        get { return this.durability; }
        set { this.durability = value; }
    }


    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }


    public int Acceleration
    {
        get { return this.acceleration; }
        set { this.acceleration = value; }
    }


    public int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = value; }
    }

    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        set { this.yearOfProduction = value; }
    }


    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }


    public string Brand
    {
        get { return this.brand; }
        set { this.brand = value; }
    }

    public override string ToString()
    {
        StringBuilder printCar = new StringBuilder();
        printCar.AppendLine($"{Brand} {Model} {YearOfProduction}");
        printCar.AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s");
        printCar.AppendLine($"{Suspension} Suspension force, {Durability} Durability");
        return printCar.ToString();
    }
}

