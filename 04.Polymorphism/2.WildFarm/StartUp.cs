using System;

public class StartUp
{
    public static void Main()
    {
        

        Animal mammal = new Mammal();
        string input = Console.ReadLine();


        for (int i = 1; i > 0 ; i++)
        {
            if (input == "End")
            {
                break;
            }
            if (i / 2 != 0)
            {
                string[] animalDesription = input.Split();

                string animalType = animalDesription[0];
                string animalName = animalDesription[1];
                double animalWeight = double.Parse(animalDesription[2]);
                string livingRegion = animalDesription[3];

                if (animalDesription.Length > 4)
                {
                    string catBreed = animalDesription[4];
                    mammal = new Cat(animalType, animalName, animalWeight, livingRegion, catBreed);
                    continue;
                }
                mammal = new Mammal(animalType, animalName, animalWeight, livingRegion);
            }
            else
            {
                string[] food = input.Split();
                string foodType = food[0];
                int quantity = int.Parse(food[1]);
     //mammal.Eat();
            }

            

            input = Console.ReadLine();
        }
    }
}

