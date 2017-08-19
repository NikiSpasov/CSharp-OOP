namespace ReflectionTutorial.Cars
{
    using System;

    public class Opel : Car
    {
        private const string bestCar = "Merc, Opel said.";
        private const string modelToReturn = "Admiral";

        public Opel()
        {
        }

        public Opel(string brand, string model, int yearOfProduction)
            : base(brand, model, yearOfProduction)
        {
        }

        public static string SayYourBestModel()
        {
            return modelToReturn;
        }

        public override void BestCarsInfo()
        {
            Console.WriteLine(bestCar);
        }

        public override void Drive(int num)
        {
            Console.WriteLine($"Brummm, brummm with a {num} nummm..., Opel Said");
        }

        public override void GiveMeTheYear()
        {
            Console.WriteLine(base.YearOfProduction);
        }

 
    }
}
