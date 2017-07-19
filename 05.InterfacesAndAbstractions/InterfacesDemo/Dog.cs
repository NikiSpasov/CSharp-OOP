public class Dog : IAnimal
    {
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public int Age { get; }

        public string MakeNoise()
        {
            return "Bau!";
        }



    
    }

