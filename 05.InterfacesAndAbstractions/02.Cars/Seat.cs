using System.Globalization;
using System.Text;

public class Seat : Car
{
    public Seat(string model, string color) : base(model, color)
    {
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {nameof(Seat)} {this.Model}");
        sb.AppendLine(base.ToString());
        return sb.ToString().Trim();
    }

}

