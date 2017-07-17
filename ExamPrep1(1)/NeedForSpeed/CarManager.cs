
using System;
using System.Collections.Generic;

public class CarManager : Car
{
    public Dictionary<int, Car> RegistredCars = new Dictionary<int, Car>();

    public Garage Garage = new Garage();

    public void Register(int id, string type, string brand, string model,
        int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        Car currentCar = new Car();
        if (type == "Performance")
        {
            currentCar = new PerformanceCar(brand, model, yearOfProduction, horsepower,
                acceleration, suspension, durability, new List<string>());
        }
        else if (type == "Show")
        {
            currentCar = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration,
                suspension, durability, 0);
        } 
        RegistredCars.Add(id, currentCar);
    }

    public string Check(int id)
    {
       return RegistredCars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        List<Car> carsRegistred = new List<Car>();
        foreach (var car in RegistredCars)
        {
            carsRegistred.Add(car.Value);
        }

        Race race = null;
        if (type == "Casual")
        {
            race = new CasualRace(length, route, prizePool, carsRegistred);

        }
        else if (type == "Drag")
        {
            race = new DragRace(length, route, prizePool, carsRegistred);
        }
        else
        {
            race = new DriftRace(length, route, prizePool, carsRegistred);
        }
        race.RaceCreator(id, race);
    }
    public void Participate(int carId, int raceId)
    {
        Race.RaceExtractor(raceId)
            .Participants.Add(RegistredCars[carId]);
    }

    public string Start(int id)
    {
        var race = Race.RaceExtractor(id);
        return race.PrintRaceResults(race);
    }

    public void Park(int id)
    {
        Car carForParking = RegistredCars[id];
        Garage.ParkIt(carForParking);
    }

    public void Unpark(int id)
    {
        Car carForUnarking = RegistredCars[id];
        Garage.UnparkIt(carForUnarking);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        Garage.TuneIt(tuneIndex, addOn);
    }

    public void Commands(string input)
    {
        string[] tokens = input.Split();

        switch (tokens[0])
        {
            case "register":
                Register(
                    int.Parse(tokens[1]),
                    tokens[2],
                    tokens[3],
                    tokens[4],
                    int.Parse(tokens[5]),
                    int.Parse(tokens[6]),
                    int.Parse(tokens[7]),
                    int.Parse(tokens[8]),
                    int.Parse(tokens[9]));
                break;

            case "check":
                Console.WriteLine(Check(int.Parse(tokens[1])));
                break;
            case "open":
                Open(int.Parse(tokens[1]), tokens[2], int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]));
                break;

            case "participate":
                Participate(int.Parse(tokens[1]), int.Parse(tokens[2]));
                break;

            case "start":
                Console.WriteLine(Start(int.Parse(tokens[1])));
                break;
            case "park":
                Park(int.Parse(tokens[1]));
                break;
            case "unpark":
                Unpark(int.Parse(tokens[1]));
                break;
            case "tune":
                Tune(int.Parse(tokens[1]), tokens[2]);
                break;

        }
    }
}

