
public class Box<T>
{
    private T myVar;



    public Box(T anyType)
    {
        this.myVar = anyType;
    }

    public override string ToString()
    {
        return $"{myVar.GetType().FullName}: {myVar}";
    }

}

