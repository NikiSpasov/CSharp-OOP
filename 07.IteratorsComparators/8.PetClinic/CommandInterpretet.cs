using System;
public class CommandInterpretet
{
    /*
     * creating a pet, creating a clinic, adding a pet to a clinic, 
     * releasing a pet from a clinic, printing information about a specific 
     * room in a clinic or printing information about all rooms in a clinic.
     */

    public void Interpret(string[] cmdArgs)
    {
        switch (cmdArgs[0])
        {
            case "":
                CreatePet();
                break;
            case "":
                CreateClinic();
                break;
            case "":
                AddPetToClinic();
                break;
            case "":
                ReleasePetFromClinic();
                break;
            case "":
                PrintRoom();
                break;
            case "":
                PrintAllRooms();
                break;
            default:
                Console.WriteLine("No such a command!");
                return;
        }
    }

}
