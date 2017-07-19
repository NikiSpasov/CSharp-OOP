public class InterfacesDemo
{
    public static void Main()
    {
        IAnimal cat = new Cat("Pesho", 4);
        IAnimal dog = new Dog("Goshko", 5);
        IAnimal rabbit = new Bunny();
    }
}

