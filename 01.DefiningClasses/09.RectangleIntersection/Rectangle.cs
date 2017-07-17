
class Rectangle
{
    public string ID;
    public int width;
    public int height;
    public int X;
    public int Y;

    public Rectangle (string ID, int width, int height, int X, int Y)
    {
        this.ID = ID;
        this.width = width;
        this.height = height;
        this.X = this.height;
        this.Y = Y;
    }

    public static bool isIntersect (Rectangle first, Rectangle second)
    {
        if ((second.X >= first.X && second.X <= first.width)
            && (second.Y >= first.Y && second.Y <= first.height))
            {
                return true;
            }
            return false;
    }
}

