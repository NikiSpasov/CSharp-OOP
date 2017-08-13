public interface IObserver
{
    int Number { get; }

    void Notify(int number);
}

