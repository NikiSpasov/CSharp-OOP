public class Tuple<T, Y>
{
    private T item1;
    private Y item2;



    public T Item1
    {
        get => item1;
        set { this.item1 = value; }
    }

    public Y Item2
    {
        get => this.item2;
        set { this.item2 = value; }
    }

    public Tuple (T item1, Y item2)
    {
        Item1 = item1;
        Item2 = item2;
    }
}

