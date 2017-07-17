
using System;

public abstract class Vehicle
{
    protected double fuelQnty;
    protected double littersPerKm;
    protected double distanceToMove;
    protected double tankCapacity;

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }

    public double LittersPerKm
    {
        get { return this.littersPerKm; }
        set { this.littersPerKm = value; }
    }

    public double FuelQnty
    {
        get { return this.fuelQnty; }
        set { this.fuelQnty = value; }
    }

    internal double DistanceToMove
    {
        get { return this.distanceToMove; }
        set { this.distanceToMove = value; }
    }
    public abstract double TotalLitPerKm();

    public abstract void Refuel(Vehicle vehicle, double litters);

    protected Vehicle(double fuelQnty, double littersPerKm, double tankCapacity)
    {
        FuelQnty = fuelQnty;
        LittersPerKm = littersPerKm;
        TankCapacity = tankCapacity;
    }

    private double DistanceCanMove(Vehicle vehicle)
    {
        return vehicle.FuelQnty / vehicle.TotalLitPerKm();
    }
    internal virtual void Drive(Vehicle vehicle, string type)
    {
        if (DistanceCanMove(vehicle) >= vehicle.DistanceToMove)
        {
            Console.WriteLine($"{type} travelled {vehicle.DistanceToMove} km");

            vehicle.FuelQnty -= TotalLitPerKm() * vehicle.DistanceToMove;
        }
        else
        {
            Console.WriteLine($"{type} needs refueling");
        }
    }
}

