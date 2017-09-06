using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Printer
{
    public void PrintAnalyze(Dictionary<string, Hardware> hardware)
    {
        int totalMemoryConsumption =
            hardware.Values
            .Select(y => y.SoftwareDict.Values
            .Select(x => x.MemoryConsumption)
            .Sum())
            .Sum();

        int totalMemory = hardware.Values
            .Select(x => x.MaxMemory)
            .Sum();

        int totalCapacityTaken = hardware.Values
            .Select(y => y.SoftwareDict.Values
            .Select(x => x.CapacityCosnsumption)
            .Sum())
            .Sum();

        int totalCapacity = hardware.Values.Select(x => x.MaxCapacity).Sum();

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("System Analysis");
        sb.AppendLine($"Hardware Components: {hardware.Count}");
        sb.AppendLine($"Software Components: {hardware.Values.Sum(x => x.SoftwareDict.Count)}");
        sb.AppendLine($"Total Operational Memory: {totalMemoryConsumption} / {totalMemory}");
        sb.AppendLine($"Total Capacity Taken: {totalCapacityTaken} / {totalCapacity}");

        Console.WriteLine(sb.ToString().Trim());
    }

    public void PrintSystemSplit(Dictionary<string, Hardware> hardware)
    {

        StringBuilder sb = new StringBuilder();

        foreach (var hard in hardware.OrderByDescending(x => x.Value.Type))
        {
            int totalMemoryConsumption =
                hard.Value.SoftwareDict.Values
                        .Select(x => x.MemoryConsumption)
                        .Sum();

            int totalMemory = hard.Value.MaxMemory;

            int totalCapacityTaken =
                     hard.Value.SoftwareDict.Values
                    .Select(x => x.CapacityCosnsumption)
                    .Sum();

            int totalCapacity = hard.Value.MaxCapacity;

            string type = hard.Value.Type;

            var names = new List<string>();

            foreach (var name in hard.Value.SoftwareDict.Values.Select(x => x.Name))
            {
                names.Add(name);
            }

            sb.AppendLine($"Hardware Component - {hard.Key}");
            sb.AppendLine($"Express Software Components - {hard.Value.SoftwareDict.Values.Count(x => x.Type == "Express")}"); // "-" or ":"?
            sb.AppendLine($"Light Software Components - {hard.Value.SoftwareDict.Values.Count(x => x.Type == "Light")}");
            sb.AppendLine($"Memory Usage: {totalMemoryConsumption} / {totalMemory}");
            sb.AppendLine($"Capacity Usage: {totalCapacityTaken} / {totalCapacity}");
            sb.AppendLine($"Type: {type}");
            if (hard.Value.SoftwareDict.Count == 0)
            {
                sb.AppendLine("Software Components: None");
                break; // ?
            }
            sb.AppendLine($"Software Components: {string.Join(", ", names)}");
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}