public class Threeuple<T, C, V>
{

    private T item1;
    private C item2;
    private V item3;

    public Threeuple(T item1, C item2, V item3)
    {
        Item1 = item1;
        Item2 = item2;
        Item3 = item3;
    }

    public T Item1
    {
        get => item1;
        set { this.item1 = value; }
    }

    public C Item2
    {
        get => this.item2;
        set { this.item2 = value; }
    }

    public V Item3
    {
        get => this.item3;
        set { this.item3 = value; }
    }
}

