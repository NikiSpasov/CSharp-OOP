
public class Rectangle : Shape
{
    protected double height;
    protected double width;

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Height
    {
        get { return this.height; }
        set { height = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }
    public override double CalculateArea()
    {
        return Height * Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Height + 2 * Width;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

