using System;

public class StartUp
{
    public static void Main()
    {

        string[] carInfo = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
        string[] truckInfo = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
        string[] busInfo = Console.ReadLine().Split();
        Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]) + 1.4, double.Parse(busInfo[3]));

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            if (tokens[0] == "Drive")
            {
                double kilometers = double.Parse(tokens[2]);
           
                switch (tokens[1])
                {
                    case "Car":
                        car.DistanceToMove = kilometers;
                        car.Drive(car, tokens[1]);
                        break;
                    case "Truck":
                        truck.DistanceToMove = kilometers;
                        truck.Drive(truck, tokens[1]);
                        break;
                    case "Bus":
                        bus.DistanceToMove = kilometers;
                        bus.Drive(bus, tokens[1]);
                        break;
                }
            }
            else if (tokens[0] == "Refuel")
            {
                double litters = double.Parse(tokens[2]);
                switch (tokens[1])
                {
                    case "Car":
                        car.Refuel(car, litters);
                        break;
                    case "Truck":
                        truck.Refuel(truck, litters);
                        break;
                    case "Bus":
                        bus.Refuel(bus, litters);
                        break;
                }
            }
            else if (tokens[0] == "DriveEmpty")
            {
                 bus.DistanceToMove = double.Parse(tokens[2]);
                 bus.LittersPerKm -= 1.4;
                 bus.Drive(bus, "Bus");
            }
        }
        Console.WriteLine($"Car: {car.FuelQnty:F2}");
        Console.WriteLine($"Truck: {truck.FuelQnty:F2}");
        Console.WriteLine($"Bus: {bus.FuelQnty:F2}");
    }
}
