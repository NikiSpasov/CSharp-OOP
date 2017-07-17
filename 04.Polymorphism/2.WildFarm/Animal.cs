
public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;

    public int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }
    public double AnimalWeight
    {
        get { return this.animalWeight; }
        set { this.animalWeight = value; }
    }

    public string AnimalType
    {
        get { return this.animalType; }
        set { this.animalType = value; }
    }

    public string AnimalName
    {
        get { return this.animalName; }
        set { this.animalName = value; }
    }
    public Animal(string animalType, string animalName, double animalWeight) //{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} 
    {
        AnimalName = animalName;
        AnimalType = animalType;
        AnimalWeight = animalWeight;
    }

    public Animal()
    {
        
    }

    public abstract void Eat(Food food);
    public abstract void MakeSound();


}

