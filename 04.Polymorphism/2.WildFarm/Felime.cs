
    public abstract class Felime : Mammal
    {
        public override void MakeSound()
        {
            throw new System.NotImplementedException();
        }

        public override void Eat(Food food)
        {
            throw new System.NotImplementedException();
        }

        public Felime(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
        {
            
        }
    }

