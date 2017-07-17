
using System;

public class Car : Vehicle
{
    public Car(double fuelQnty, double littersPerKm, double tankcapacity) :
        base(fuelQnty, littersPerKm, tankcapacity)
    {
    }
    public override double TotalLitPerKm()
    {
        return base.LittersPerKm + 0.9;
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

