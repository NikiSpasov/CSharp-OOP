using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class CommandInterpreter
{
    private Dictionary<string, Hardware> hardware = new Dictionary<string, Hardware>();
    private Printer printer = new Printer();

    public void Interpret(string command, string[] args)
    {
        switch (command)
        {
            case "RegisterPowerHardware":
                Hardware currentHardPower = new PowerHardware(args[0], 
                    int.Parse(args[1]), int.Parse(args[2]));
                this.hardware.Add(args[0], currentHardPower);
                break;

            case "RegisterHeavyHardware":
                Hardware currentHardHeavy = new HeavyHardware(args[0],
                    int.Parse(args[1]), int.Parse(args[2]));
                this.hardware.Add(args[0], currentHardHeavy);
                break;

            case "RegisterExpressSoftware":
                string hardNameForExpressSoft = args[0];
                Software expresSoftware = new ExpressSoftware(args[1],
                    int.Parse(args[2]), int.Parse(args[3]));
                if (this.hardware.ContainsKey(hardNameForExpressSoft))
                {
                    this.hardware[hardNameForExpressSoft].RegisterSoftware(expresSoftware);
                }
                break;

            case "RegisterLightSoftware":
                string hardNameForLightSoft = args[0];
                Software lightSoftware = new LightSoftware(args[1],
                    int.Parse(args[2]), int.Parse(args[3]));
                if (this.hardware.ContainsKey(hardNameForLightSoft))
                {
                    this.hardware[hardNameForLightSoft].RegisterSoftware(lightSoftware);
                }
                break;

            case "ReleaseSoftwareComponent":
                string hardWithThisComponent = args[0];
                string nameOfSoft = args[1];
                
                if (this.hardware.ContainsKey(hardWithThisComponent))
                {
                    if (this.hardware[hardWithThisComponent].SoftwareDict.ContainsKey(nameOfSoft))
                    {
                        this.hardware[hardWithThisComponent].SoftwareDict.Remove(nameOfSoft);
                    }
                }
                break;

            case "Analyze":
                this.printer.PrintAnalyze(this.hardware);
                break;

            case "System":
                this.printer.PrintSystemSplit(this.hardware);
                break;
        }
    }
}

