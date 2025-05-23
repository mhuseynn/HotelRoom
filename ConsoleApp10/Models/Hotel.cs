﻿namespace ConsoleApp10.Models;

class Hotel
{
    static int _id = 0;

    public int Id { get; set; }
    public string Name { get; set; }

    private Room[] Rooms { get; set; }

    public Hotel(string name)
    {
        Id = _id++;
        Name = name;
        Rooms = new Room[0];
    }


    public void AddRoom(Room room)
    {
        Room[] newArr = new Room[Rooms.Length + 1];

        for (int i = 0; i < Rooms.Length; i++)
        {
            newArr[i] = Rooms[i];
        }
        newArr[Rooms.Length] = room;
        Rooms = newArr;
    }

    public void MakeReservation(int id)
    {
        foreach (Room room in Rooms)
        {
            if (room.Id == id)
            {
                if (room.IsAvailable)
                {
                    room.IsAvailable = false;
                    Console.WriteLine("Rezerv olundu");
                    break;
                }
                else
                    Console.WriteLine("Otaq doludu");
            }
            else
            {
                Console.WriteLine("id sehvdi");
            }
        }

    }
}
