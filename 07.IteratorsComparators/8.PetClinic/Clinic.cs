using System;
using System.Collections.Generic;
using System.Linq;

public class Clinic
{
    private string name;
    private int roomsQuantity;
    private List<Room> rooms;
    public static List<Clinic> Clinics = new List<Clinic>();

    public Clinic(string name, int roomQuantity)
    {
        this.Rooms = new List<Room>();
        this.RoomsQuantity = roomQuantity;
        for (int i = 0; i < this.RoomsQuantity; i++)
        {
            Rooms.Add(new Room(i + 1));
        }
        this.Name = name;
    }

    public static void CreateClinic(List<string> cmdArgs)
    {
        try
        {
            Clinic clinic = new Clinic(cmdArgs[0], int.Parse(cmdArgs[1]));
            Clinics.Add(clinic);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static bool AddPetToClinic(string petName, string clinicName)
    {
        try
           
        {
            Clinic clinicToAddIn = Clinics.Find(x => x.Name == clinicName);
            int initalIndex = clinicToAddIn.Rooms.Count / 2;
            Pet petToAdd = Pet.PetList.Where(x => x.Name == petName).First();

            if (clinicToAddIn.Rooms.TrueForAll(x => x.ContainsPet))
            {
                return false;
            }
            int steps = 1;
            int i = initalIndex;

            for (int j = 0; j < clinicToAddIn.Rooms.Count; j++)
            {
               
                if (!clinicToAddIn.Rooms[i].ContainsPet)
                {
                    clinicToAddIn.Rooms[i].PetInTheRoom = petToAdd;
                    clinicToAddIn.Rooms[i].ContainsPet = true;
                    return true;
                }
                if (i >= initalIndex)
                {
                    i = initalIndex - steps;
                }
                else
                {
                    i = initalIndex + steps;
                    steps++;
                }
            }
        }
        catch (Exception e)
        {
            return false;
        }
        return false;
    }

    public static bool ReleasePetFromClinic(string clinicName)
    {
        var currentListOfRooms = Clinics.Find(x => x.Name == clinicName).Rooms;
        var currentRoom = currentListOfRooms[currentListOfRooms.Count / 2];
        if (currentRoom.ContainsPet)
        {
            currentRoom.PetInTheRoom = null;
            currentRoom.ContainsPet = false;
            return true;
        }
        for (int i = currentListOfRooms.IndexOf(currentRoom) + 1; i < currentListOfRooms.Count; i++)
        {
            if (currentListOfRooms[i].ContainsPet)
            {
                currentListOfRooms[i].PetInTheRoom = null;
                currentListOfRooms[i].ContainsPet = false;
                return true;
            }
        }
        for (int i = currentListOfRooms.IndexOf(currentRoom) - 1; i <= 0; i--)
        {
            if (currentListOfRooms[i].ContainsPet)
            {
                currentListOfRooms[i].PetInTheRoom = null;
                currentListOfRooms[i].ContainsPet = false;
                return true;
            }
        }
        return false;
    }

    public static void PrintEveryRoomInClinic(string clinicName)
    {
        foreach (var clinic in Clinics.Where(x => x.Name == clinicName))
        {
            foreach (var room in clinic.rooms.OrderBy(x => x.Number))
            {
                Console.WriteLine(room.ContainsPet == false
                    ? "Room empty"
                    : $"{room.PetInTheRoom.Name} {room.PetInTheRoom.Age} {room.PetInTheRoom.Kind}");
            }
        }
    }

    public static void PrintClinicRoom(string clinicName, int roomNumber)
    {
        Room room = Clinics.First(x => x.Name == clinicName)
                   .Rooms.First(x => x.Number == roomNumber);
        Console.WriteLine(room.ContainsPet == false
            ? "Room empty"
            : $"{room.PetInTheRoom.Name} {room.PetInTheRoom.Age} {room.PetInTheRoom.Kind}");
    }

    public static bool HasEmptyRooms(string clinicName)
    {
        Clinic clinic = Clinics.Find(x => x.Name == clinicName);
        if (clinic.Rooms.Any(x => x.ContainsPet == false))
        {
            return true;
        }
        return false;
    }

    public int RoomsQuantity
    {
        get => this.roomsQuantity;
        set
        {
            if (value % 2 == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            this.roomsQuantity = value;
        }
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public List<Room> Rooms
    {
        get => this.rooms;
        private set => this.rooms = value;
    }


}


