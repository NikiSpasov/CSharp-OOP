public class Pet
{
    private string name;
    private int age;
    private string kind;

    public Pet()
    {

    }

    public string Kind
    {
        get { return this.kind; }
        set { this.kind = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }


    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

}

