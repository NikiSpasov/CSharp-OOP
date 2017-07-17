using System;

public class Bus : Vehicle
{
    public Bus(double fuelQnty, double littersPerKm, double tankCapacity) : base(fuelQnty, littersPerKm, tankCapacity)
    {
    }

    public override double TotalLitPerKm()
    {
        return base.LittersPerKm;
    }

    public override void Refuel(Vehicle vehicle, double litters)
    {
        if (vehicle.FuelQnty + litters > vehicle.TankCapacity)
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }
        else if (litters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            vehicle.FuelQnty += litters;
        }
    }
}

