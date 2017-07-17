
using System;
using System.Text;

internal class ShowCar : Car
{
    private int stars;

    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, 
        int suspension, int durability, int stars) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        Stars = 0;
        Stars = stars;
    }
 
    public override string ToString()
    {
        StringBuilder printCar = new StringBuilder();
        printCar.AppendLine($"{Brand} {Model} {YearOfProduction}");
        printCar.AppendLine($"{Horsepower} HP, 100 m/h in {Acceleration} s");
        printCar.AppendLine($"{Suspension} Suspension force, {Durability} Durability");
        printCar.AppendLine($"{Stars} *");

        return printCar.ToString();

    }

}

