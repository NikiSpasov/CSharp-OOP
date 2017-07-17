using System;
using System.Collections.Generic;
using System.Linq;

public class DraftManager
{
    public Dictionary<string, Harvester> Harvesters = new Dictionary<string, Harvester>();
    public Dictionary<string, Provider> Providers = new Dictionary<string, Provider>();
    public double totalEnergyStored;
    public double totalMinedOre;
    public string currentMode = "Full";


    public string RegisterHarvester(List<string> arguments)
    {
        Harvester currentHarvester;
        if (arguments[1] == "Sonic")
        {
            currentHarvester = new SonicHarvester(
                arguments[2], double.Parse(arguments[3]), double.Parse(arguments[4]), int.Parse(arguments[5]));
        }
        else
        {
             currentHarvester = new HammerHarvester(arguments[1], arguments[2], double.Parse(arguments[3]),
                double.Parse(arguments[4]));
        }
        Harvesters.Add(currentHarvester.Id, currentHarvester);
        return $"Successfully registered {arguments[1]} Harvester – {currentHarvester.Id}";
    }
    public string RegisterProvider(List<string> arguments)
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

        Providers.Add(currentProvider.Id, currentProvider);

        return $"Successfully registered {arguments[1]} Provider – {currentProvider.Id}";
    }
    public string Day()
    {
        double summedEnergyOutput = Providers.Sum(x => x.Value.EnergyOutput);
        totalEnergyStored += Providers.Sum(x => x.Value.EnergyOutput);
        double summedOreOutput = 0;
        double energyRequirement = 0;
        summedOreOutput = Harvesters.Sum(x => x.Value.OreOutput);



        if (currentMode == "Full")
        {
            energyRequirement = Harvesters.Sum(x => x.Value.EnergyRequirement);

        }
        if (currentMode == "Half")
        {
            energyRequirement = energyRequirement * 60 / 100;
            summedOreOutput = summedOreOutput * 50 / 100;
        }

        if (energyRequirement <= summedEnergyOutput && currentMode != "Energy") //CHECKKK
        {
            summedEnergyOutput -= energyRequirement; //CHECKKK
            totalMinedOre += summedOreOutput;
        }

        return $"A day has passed." +
               $"{Environment.NewLine}Energy Provided: {summedEnergyOutput}" +
               $"{Environment.NewLine}Plumbus Ore Mined: {summedOreOutput}";
    }
    public string Mode(List<string> arguments)
    {
        currentMode = arguments[1];
        return $"Successfully changed working mode to {currentMode} Mode";
    }
    public string Check(List<string> arguments)
    {
        string id = arguments[1];
        if (Harvesters.ContainsKey(id))
        {
            var h = Harvesters[id];
            if (h.GetType().ToString() == "SonicHarvester")
            {
                return $"Sonic Harvester - {id}{Environment.NewLine}Ore Output: {h.OreOutput}" +
                       $"{Environment.NewLine}Energy Requirement: {h.EnergyRequirement}";
            }

                return $"Hammer Harvester - {id}{Environment.NewLine}Ore Output: {h.OreOutput}" +
                       $"{Environment.NewLine}Energy Requirement: {h.EnergyRequirement}";
        }
        else if (Providers.ContainsKey(id))
        {
            var p = Providers[id];
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
            $"Total Energy Stored: {totalEnergyStored}"+
            $"{Environment.NewLine}Total Mined Plumbus Ore: {totalMinedOre}";
    }

}

