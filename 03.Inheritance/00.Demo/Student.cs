
using System;

public class Student : Person
{
    private string school;

    private int height;

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }


    public string School
    {
        get { return this.school; }
        set { this.school = value; }
    }

    public Student(int height) 
        :base(height)
    {
    }

    public void Print()
    {
        double height = 177.7;
        Console.WriteLine(height); //177.7 - взима си горната променлива
        Console.WriteLine(this.height);//188 - взима си я от конкретния обект през конструктора
        Console.WriteLine(base.height);//165 - отива и гледа в базовия клас тази стойност!
    }

}

