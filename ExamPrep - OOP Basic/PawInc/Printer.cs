using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Printer
{
    public void Print(Dictionary<string, CleansingCenter> cleansingCenters,
        Dictionary<string, AdoptionCenter> adoptionCenters)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Paw Incorporative Regular Statistics");
        sb.AppendLine($"Adoption Centers: {adoptionCenters.Count}");
        sb.AppendLine($"Cleansing Centers: {cleansingCenters.Count}");

        if (AdoptionCenter.AdoptedAnimals.Count != 0)//names
        {
            sb.AppendLine($"Adopted Animals: {string.Join(", ", AdoptionCenter.AdoptedAnimals.Select(x => x.Name).OrderBy(x => x, StringComparer.CurrentCulture))}");
        }
        else
        {
            sb.AppendLine($"Adopted Animals: None");
        }


        List<Animal> cleanedAnimals = new List<Animal>();
        foreach (var cleanCenter in cleansingCenters)
        {
            var animals = cleanCenter.Value.CleansedAnimals;
            foreach (var animal in animals)
            {
                cleanedAnimals.Add(animal);
            }
        }

        if (cleanedAnimals.Count != 0)
        {
            sb.AppendLine($"Cleansed Animals: {string.Join(", ", cleanedAnimals.Select(x => x.Name).OrderBy(x => x, StringComparer.CurrentCulture))}");
        }
        else
        {
            sb.AppendLine($"Cleansed Animals: None");
        }

        int awaitingAdoption = 0;
        foreach (var adoptionCntrs in adoptionCenters)
        {
            var animalsAwaiting = adoptionCntrs.Value.Animals;
            foreach (var animal in animalsAwaiting.Where(x => x.CleansingStatus))
            {
                awaitingAdoption++;
            }
        }

        sb.AppendLine($"Animals Awaiting Adoption: {awaitingAdoption}");

        int awaitingCleasing = 0;
        foreach (var cleanCntr in cleansingCenters)
        {
            var animalsAwaiting = cleanCntr.Value.Animals.Where(x => x.CleansingStatus == false);
            foreach (var animal in animalsAwaiting)
            {
                awaitingCleasing++;
            }
        }

        sb.AppendLine($"Animals Awaiting Cleansing: {awaitingCleasing}");

        Console.WriteLine(sb.ToString());
    }
}