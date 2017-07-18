using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    public double totalEnergyStored;
    public double totalMinedOre;
    public string currentMode;


    public DraftManager()
    {
        this.currentMode = "Full";
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        Harvester currentHarvester = null;

        try
        {

            if (arguments[1] == "Sonic")
            {
                currentHarvester = new SonicHarvester(
                arguments[2], double.Parse(arguments[3]), double.Parse(arguments[4]), int.Parse(arguments[5]));

            }
            if (arguments[1] == "Hammer")
            {
                currentHarvester = new HammerHarvester(arguments[1], arguments[2], double.Parse(arguments[3]),
                double.Parse(arguments[4]));
            }
            harvesters.Add(currentHarvester.Id, currentHarvester);
            return $"Successfully registered {arguments[1]} Harvester – {currentHarvester.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }

    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider currentProvider;
            if (arguments[1] == "Solar")
            {
                currentProvider = new SolarProvider(arguments[2], double.Parse(arguments[3]));
            }
            else
            {
                currentProvider = new PressureProvider(arguments[2], double.Parse(arguments[3]));
            }

            providers.Add(currentProvider.Id, currentProvider);

            return $"Successfully registered {arguments[1]} Provider – {currentProvider.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
        
    }
    public string Day()
    {
        double energyProvidedThisDay = 0;
        double oreMinedThisDay = 0;
        double totalEnergyRequirement = 0;


        if (this.harvesters.Count == 0)
        {
            energyProvidedThisDay = providers.Sum(p => p.Value.EnergyOutput);
            oreMinedThisDay = 0;

            this.totalEnergyStored += energyProvidedThisDay;
        }
        switch (currentMode)
        {
            case "Full":

                totalEnergyRequirement = harvesters.Sum(h => h.Value.EnergyRequirement);
                energyProvidedThisDay = providers.Sum(h => h.Value.EnergyOutput);

                if (energyProvidedThisDay + this.totalEnergyStored >= totalEnergyRequirement)
                {
                    oreMinedThisDay = harvesters.Sum(h => h.Value.OreOutput);

                    this.totalEnergyStored += energyProvidedThisDay - totalEnergyRequirement;
                    this.totalMinedOre += oreMinedThisDay;
                }
                else
                {
                    this.totalEnergyStored += energyProvidedThisDay;
                }

                break;

            case "Half":

                energyProvidedThisDay = providers.Sum(p => p.Value.EnergyOutput);
                totalEnergyRequirement = harvesters.Sum(h => h.Value.EnergyRequirement * 60 / 100);

                if (energyProvidedThisDay + this.totalEnergyStored >= totalEnergyRequirement)
                {
                    oreMinedThisDay = harvesters.Sum(h => h.Value.OreOutput * 50 / 100);

                    this.totalEnergyStored += energyProvidedThisDay - totalEnergyRequirement;
                    this.totalMinedOre += oreMinedThisDay;
                }
                else
                {
                    this.totalEnergyStored += energyProvidedThisDay;
                }
                break;

            default:
                energyProvidedThisDay = providers.Sum(p => p.Value.EnergyOutput); 
                totalEnergyStored += energyProvidedThisDay;
                break;
        }

        return $"A day has passed." +
               $"{Environment.NewLine}Energy Provided: {energyProvidedThisDay}" +
               $"{Environment.NewLine}Plumbus Ore Mined: {oreMinedThisDay}";
    }
    public string Mode(List<string> arguments)
    {
        currentMode = arguments[1];
        return $"Successfully changed working mode to {currentMode} Mode";
    }
    public string Check(List<string> arguments)
    {
        string id = arguments[1];
        if (harvesters.ContainsKey(id))
        {
            var h = harvesters[id];
            if (h.GetType().ToString() == "SonicHarvester")
            {
                return $"Sonic Harvester - {id}{Environment.NewLine}Ore Output: {h.OreOutput}" +
                       $"{Environment.NewLine}Energy Requirement: {h.EnergyRequirement}";
            }

            return $"Hammer Harvester - {id}{Environment.NewLine}Ore Output: {h.OreOutput}" +
                   $"{Environment.NewLine}Energy Requirement: {h.EnergyRequirement}";
        }
        else if (providers.ContainsKey(id))
        {
            var p = providers[id];
            if (p.GetType().ToString() == "SolarProvider")
            {
                return $"Solar Provider - {id}{Environment.NewLine}" +
                       $"Energy Output: {p.EnergyOutput}";
            }
            return $"Pressure Provider - {id}{Environment.NewLine}" +
                   $"Energy Output: {p.EnergyOutput}";

        }
        else
        {
            return $"No element found with id - {id}";
        }
    }
    public string ShutDown()
    {
        return
            $"System Shutdown{Environment.NewLine}" +
            $"Total Energy Stored: {totalEnergyStored}" +
            $"{Environment.NewLine}Total Mined Plumbus Ore: {totalMinedOre}";
    }

}

