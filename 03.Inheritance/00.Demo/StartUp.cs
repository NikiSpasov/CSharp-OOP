
public class StartUp
{
    static void Main()
    {
        Student student = new Student(188);
        student.Name = "Pesho";
        student.Age = 24;
        student.School = "SoftUni";

        student.Print();

    }
}

