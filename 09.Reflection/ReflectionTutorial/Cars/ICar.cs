namespace ReflectionTutorial
{
    public interface ICar
    {

        string Brand { get; }
        string Model { get; }
        int YearOfProduction { get; }

        void BestCarsInfo();

        void Drive(int num);

        void GiveMeTheYear();

    }
}
