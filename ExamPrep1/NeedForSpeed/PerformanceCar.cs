
using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public List<string> AddOns
    {
        get { return this.addOns; }
        set { this.addOns = value; }
    }
    
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability, List<string> addOns) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        AddOns = addOns;
        Horsepower = horsepower + (horsepower * 50) / 100;
        Suspension = suspension - (suspension * 25) / 100;
    }

    public override string ToString()
    {
        StringBuilder printCar = new StringBuilder();
        printCar.AppendLine($"{Brand} {Model} {YearOfProduction}");
        printCar.AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s");
        printCar.AppendLine($"{Suspension} Suspension force, {Durability} Durability");
        if (AddOns.Count == 0 || AddOns == null)
        {
            printCar.AppendLine($"Add-ons: None");
        }
        else
        {
        printCar.AppendLine($"Add-ons: {String.Join(", ", AddOns)}");
        }

        return printCar.ToString();

    }
}

