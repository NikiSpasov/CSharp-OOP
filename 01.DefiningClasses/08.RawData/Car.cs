public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire tire;
    
    public Car(string model, Engine engine, Cargo cargo, Tire tire)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tire = tire;
    }

    public string Model => model;
    public Engine Engine => engine;
    public Cargo Cargo => cargo;
    public Tire Tire => tire;
}

