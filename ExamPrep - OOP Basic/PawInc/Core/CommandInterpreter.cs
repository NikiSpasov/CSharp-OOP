using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    private Dictionary<string, CleansingCenter> cleansingCenters = new Dictionary<string, CleansingCenter>();
    private Dictionary<string, AdoptionCenter> adoptionCenters = new Dictionary<string, AdoptionCenter>();
    private Printer printer = new Printer();

    public void interpret(string[] args)
    {
        string command = args[0];

        switch (command)
        {
            case "RegisterCleansingCenter":
                CleansingCenter currentCleansingCenter = new CleansingCenter(args[1]);
                cleansingCenters.Add(args[1], currentCleansingCenter);
                break;

            case "RegisterAdoptionCenter":
                AdoptionCenter currentAdoptionCenter = new AdoptionCenter(args[1]);
                adoptionCenters.Add(args[1], currentAdoptionCenter);
                break;

            case "RegisterDog":
                Dog currentDog = new Dog(args[1], int.Parse(args[2]), int.Parse(args[3]));
                if (adoptionCenters.ContainsKey(args[4]))
                {
                    adoptionCenters[args[4]].Animals.Add(currentDog);
                }
                break;

            case "RegisterCat":
                Cat currentCat = new Cat(args[1], int.Parse(args[2]), int.Parse(args[3]));
                if (adoptionCenters.ContainsKey(args[4]))
                {
                    adoptionCenters[args[4]].Animals.Add(currentCat);
                }
                break;

            case "SendForCleansing":
                string adoptionCenterName = args[1];
                string cleansingCenterName = args[2];

                if (!this.cleansingCenters[cleansingCenterName].SendersAndAnimals.ContainsKey(adoptionCenterName))
                {
                    this.cleansingCenters[cleansingCenterName].SendersAndAnimals.
                        Add(adoptionCenterName, new List<Animal>(
                        this.adoptionCenters[adoptionCenterName].Animals
                        .Where(x => x.CleansingStatus == false)));
                }

                else
                {
                    foreach (var animal in this.adoptionCenters[adoptionCenterName].Animals
                        .Where(x => x.CleansingStatus == false))
                    {
                        this.cleansingCenters[cleansingCenterName].SendersAndAnimals[cleansingCenterName].Add(animal);
                    }
                }

                if (cleansingCenters.ContainsKey(cleansingCenterName) 
                    && adoptionCenters.ContainsKey(adoptionCenterName))
                {
                    this.adoptionCenters[adoptionCenterName].SendForCleansing(
                        this.adoptionCenters[adoptionCenterName], 
                        this.cleansingCenters[cleansingCenterName]);
                }
                break;

            case "Cleanse":
                string cleanCenterName = args[1];

                foreach (var key in this.cleansingCenters[cleanCenterName]
                    .SendersAndAnimals.Keys)
                {
                    if (this.adoptionCenters.ContainsKey(key))
                    {
                        foreach (var animal in this.cleansingCenters[cleanCenterName].SendersAndAnimals[key])
                        {
                            animal.CleansingStatus = true;
                            this.cleansingCenters[cleanCenterName].CleansedAnimals.Add(animal);
                            this.adoptionCenters[key].Animals.Add(animal);
                        }                       
                    }
                }

                this.cleansingCenters[cleanCenterName].Animals.Clear();
                                       
                break;

            case "Adopt":
                if (adoptionCenters.ContainsKey(args[1]))
                {
                    foreach (var animal in adoptionCenters[args[1]].Animals.Where(x => x.CleansingStatus))
                    {
                        AdoptionCenter.AdoptedAnimals.Add(animal);
                    }
                    adoptionCenters[args[1]].Animals = adoptionCenters[args[1]].Animals
                        .Where(x => x.CleansingStatus == false)
                        .ToList();
                }
                break;

            case "Paw":
                printer.Print(cleansingCenters, adoptionCenters);
                break;
        }
    }
}

