using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        Dictionary<string, Car> cars = new Dictionary<string, Car>();
        int carsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carsCount; i++)
        {
            string[] data = Console.ReadLine()
                .Trim()
                .Split(new []{' ', '\r', '\n', '\t'}, 
                StringSplitOptions.RemoveEmptyEntries);
            Car currentCar = new Car (data[0], double.Parse(data[1]), double.Parse(data[2]));            
            cars.Add(currentCar.model, currentCar);
        }

        cars = Car.CheckForCarsDrive(cars);

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Key} {car.Value.fuelAmount:f2} {car.Value.distanceTraveled}");
        }
    }
}

