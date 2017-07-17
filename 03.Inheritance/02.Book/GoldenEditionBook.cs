
public class GoldenEditionBook : Book
{
    public override decimal Price
    {
        get { return base.Price; }
        set { base.Price = value + (value * 30) / 100; }
    }

    public GoldenEditionBook(string author, string title, decimal price)
    : base(author, title, price)
    {

    }
}


