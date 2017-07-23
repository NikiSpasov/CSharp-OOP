using System.Linq;
using System.Collections.Generic;

public class Box<T>
{
    public IList<T> MyList;
    public int Count => this.MyList.Count;

    public void Add(T element)
    {
        this.MyList.Add(element);
    }

    public T Remove()
    {
        var elementToRemove = this.MyList.Last();
        this.MyList.RemoveAt(this.MyList.Count - 1);
        return elementToRemove;
    }

    public Box()
    {
        MyList = new List<T>();
    }
}

