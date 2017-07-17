
using System;

public class Truck : Vehicle
{
    public Truck(double fuelQnty, double littersPerKm, double tankCapacity) :
        base(fuelQnty, littersPerKm, tankCapacity)
    {
    }
    public override double TotalLitPerKm()
    {
        return base.LittersPerKm + 1.6;
    }

    public override void Refuel(Vehicle vehicle, double litters)
    {
        if (litters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            vehicle.FuelQnty += litters * 95 / 100;
        }
    }
}
