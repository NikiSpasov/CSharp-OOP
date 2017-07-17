
    public class Mammal : Animal
    {
    private string livingRegion;

    public string LivingRegion
    {
        get { return this.livingRegion; }
        set { this.livingRegion = value; }
    }
        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight)
        {
            LivingRegion = livingRegion;
        }

        public Mammal()
        {
            
        }

        public override void MakeSound()
        {
            throw new System.NotImplementedException();
        }

        public override void Eat(Food food)
        {
            throw new System.NotImplementedException();
        }
    }

