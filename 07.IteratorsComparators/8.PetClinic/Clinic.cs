using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

public class Clinic
{
    private List<Pet> petsInClinic;
    private List<Room> rooms; //only odd number! 

    public Clinic()
    {
        this.rooms = new List<Room>();
        this.petsInClinic = new List<Pet>();
    }


    public List<Room> Rooms
    {
        get => this.rooms;
        set
        {
            if (value.Count % 2 == 0)
            {
                throw new ArgumentException();
            }
            this.rooms = value;
        }
        
    }

    //CreateClinic();
    //    break;
    //    case "":
    //AddPetToClinic();
    //    break;
    //    case "":
    //ReleasePetFromClinic();
}

