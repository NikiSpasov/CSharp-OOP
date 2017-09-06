using System.Collections.Generic;
using System.Linq;

public class AdoptionCenter : Center
{
    public static List<Animal> AdoptedAnimals = new List<Animal>();

    public AdoptionCenter(string name) : base(name)
    {

    }

    public void SendForCleansing(AdoptionCenter adoptionCenter, CleansingCenter cleansingCenter)
    {
        foreach (var animal in adoptionCenter.Animals.Where(x => x.CleansingStatus == false))
        {
            cleansingCenter.Animals.Add(animal);
        }
        adoptionCenter.Animals = adoptionCenter.Animals.Where(x => x.CleansingStatus).ToList();
    }
}

