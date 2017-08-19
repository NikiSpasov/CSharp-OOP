namespace ReflectionTutorial
{
    using ReflectionTutorial.Cars;
    using System;

    public class Mercedes : Car
    {
        private const string modelToReturn = "124";

        public Mercedes() : base ()
        {
        }

        public Mercedes(string brand, string model, int yearOfProduction)
            : base (brand, model, yearOfProduction)
        {

        }

        public static string SayYourBestModel ()
        {
            return modelToReturn;
        }

        public override void BestCarsInfo()
        {
            Console.WriteLine("Just Merc and Audi");
        }

        public override void Drive(int num)
        {
            Console.WriteLine($"Brummm, brummm with a {num} nummm...");
        }

        public override void GiveMeTheYear()
        {
            Console.WriteLine(base.YearOfProduction);
        }
    }
}
