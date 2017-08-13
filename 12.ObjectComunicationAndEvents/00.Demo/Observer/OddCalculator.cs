public class OddCalculator : IObserver
{
    public int Number;

    public void Notify(int number)
    {
        this.Number = number;
    }
}

