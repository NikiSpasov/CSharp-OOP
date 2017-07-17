using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', ',', '\n', '\t', '\r' },
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Engine currentEngine = new Engine(input[0], int.Parse(input[1]));

            if (input.Length == 3)
            {
                int displacement;
                if (int.TryParse(input[2], out displacement))
                {
                    currentEngine.Displacement = input[2];

                }
                else
                {
                    currentEngine.Efficency = input[2];
                }
            }
            if (input.Length == 4)
            {
                currentEngine.Displacement = input[2];
                currentEngine.Efficency = input[3];
            }
            engines.Add(currentEngine);
        }
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', ',', '\n', '\t', '\r' },
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Engine currEngine = engines
                .Where(x => x.Model == input[1])
                .First();

            Car currentCar = new Car(input[0], currEngine);
            if (input.Length == 3)
            {
                int weight;
                if (int.TryParse(input[2], out weight))
                {
                    currentCar.Weight = weight.ToString();
                }
                else
                {
                    currentCar.Color = input[2];
                }
            }
            if (input.Length == 4)
            {
                currentCar.Weight = input[2];
                currentCar.Color = input[3];
            }
            cars.Add(currentCar);

        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model}: " +
                              $"{Environment.NewLine}  {car.Engine.Model}:" +
                              $" {Environment.NewLine}    Power: {car.Engine.Power}" +
                              $" {Environment.NewLine}    Displacement: {car.Engine.Displacement}" +
                              $" {Environment.NewLine}    Efficiency: {car.Engine.Efficency}" +
                              $"{Environment.NewLine}  Weight: {car.Weight}" +
                              $"{Environment.NewLine}  Color: {car.Color}"
                              );
        }
    }
}

