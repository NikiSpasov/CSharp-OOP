using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpretet
{
    /*
     * creating a pet, creating a clinic, adding a pet to a clinic, 
     * releasing a pet from a clinic, printing information about a specific 
     * room in a clinic or printing information about all rooms in a clinic.
     */

    public void Interpret()
    {
        List<string> cmdArgs = Console.ReadLine()
            .Split(' ')
            .ToList();

        string command = cmdArgs[0];
        cmdArgs.RemoveAt(0);

        switch (command)
        {
            case "Create":
                if (cmdArgs[0] == "Pet")
                {
                    cmdArgs.RemoveAt(0);
                    Pet.CreatePet(cmdArgs);
                }
                else if (cmdArgs[0] == "Clinic")
                {
                    cmdArgs.RemoveAt(0);
                    Clinic.CreateClinic(cmdArgs);
                }
                break;

            case "Add":
                string addResult = Clinic.AddPetToClinic(cmdArgs[0], cmdArgs[1]).ToString();
                Console.WriteLine(addResult.ToLower());
                break;

            case "Release":
                string result = Clinic.ReleasePetFromClinic(cmdArgs[0]).ToString();
                Console.WriteLine(result.ToLower());
                break;

            case "HasEmptyRooms":
                string resultFrom = Clinic.HasEmptyRooms(cmdArgs[0]).ToString();
                Console.WriteLine(resultFrom.ToLower());
                break;

            case "Print":
                if (cmdArgs.Count == 1)
                {
                    Clinic.PrintEveryRoomInClinic(cmdArgs[0]);
                }
                else
                {
                    Clinic.PrintClinicRoom(cmdArgs[0], int.Parse(cmdArgs[1]));
                }
                break;

            default:
                Console.WriteLine("No such a command!");
                return;
        }
    }

}
