
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ', '\r', '\n', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            
            Cargo cargo = new Cargo(int.Parse(data[3]), data[4]);
            Engine engine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
            double[] arrTires = 
            {
                double.Parse(data[5]),            
                double.Parse(data[7]),            
                double.Parse(data[9]),            
                double.Parse(data[11])
           };
            Tire tires = new Tire(arrTires);

            Car currentCar = new Car(data[0], engine, cargo, tires);
            cars.Add(currentCar);
        }
        string command = Console.ReadLine();
        if (command == "fragile")
        {
            foreach (var car in cars
                .Where(x => x.Cargo.CargoType == "fragile")
                .Where(y => y.Tire.FourTiresPressure.Any(x => x < 1.0)))
            {
                Console.WriteLine(car.Model);
            }
        }
        else if (command == "flamable")
        {
            foreach (var car in cars.Where(x => x.Engine.EnginePower > 250)
                .Where(y => y.Cargo.CargoType == "flamable"))
            {
                Console.WriteLine(car.Model);
            }
        }


    }
}

