
using System;
using System.Collections.Generic;

public class Car
{
    public string model;
    public double fuelAmount;
    public double fuelConsPerKm;
    public double distanceTraveled;
    // public double maxDistance => fuelAmount / fuelConsPerKm;

    public double maxDistance
    {
        get { return this.fuelAmount / this.fuelConsPerKm; }
        set { this.maxDistance = maxDistance; }
    }
    public Car(string model, double fuelAmount, double fuelConsPerKm)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsPerKm = fuelConsPerKm;
    }

    public static Dictionary<string, Car> CheckForCarsDrive(Dictionary<string, Car> cars)
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] driveIt = input
                .Trim()
                .Split( new []{' ', '\r', '\n', '\t'},
                StringSplitOptions.RemoveEmptyEntries);

            string model = driveIt[1];
            double distanceToDrive = double.Parse(driveIt[2]);

            if (cars.ContainsKey(model))
            {
                if (cars[model].maxDistance >= distanceToDrive)
                {
                    cars[model].distanceTraveled += distanceToDrive;
                    cars[model].fuelAmount -= distanceToDrive
                                              * cars[model].fuelConsPerKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            input = Console.ReadLine();
        }
        return cars;
    }
}

