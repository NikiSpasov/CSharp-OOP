
using System;
using System.Collections.Generic;

public class Garage
{
    private List<Car> parkedCars;

    public List<Car> ParkedCars
    {
        get { return this.parkedCars; }
        set { this.parkedCars = value; }
    }

    public void ParkIt(Car car)
    {
        ParkedCars.Add(car);
    }
    public void UnparkIt(Car car)
    {
        ParkedCars.Remove(car);
    }

    public void TuneIt(int tuneIndex, string tuneAddOn)
    {
        foreach (var car in ParkedCars)
        {
            car.Horsepower += tuneIndex;
            car.Suspension += tuneIndex * 50 / 100;

            string type = car.GetType().ToString();
            if (type == "ShowCar")
            {
                car.Stars += tuneIndex;
            }
            else if (type == "Performace")
            {
                car.AddOns.Add(tuneAddOn);
            }
        }
    }
}

