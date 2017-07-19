using System.Text;

public abstract class Car : ICar
{
    private string model;
    private string color;
    public Car(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model
    {
        get { return this.model; }
        protected set { this.model = value; }
    }

    public string Color
    {
        get { return this.color; }
        protected set { this.color = value; }
    }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Start()}");
        sb.AppendLine($"{Stop()}");
        return sb.ToString().Trim();
    }
}
