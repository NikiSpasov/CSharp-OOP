public class EvenCalculator : IObserver
{

    public int Number { get; set; }

    public void Notify(int number)
    {
        this.Number = number;
    }
}

