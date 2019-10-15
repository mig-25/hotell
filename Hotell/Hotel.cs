using System;
using System.Collections.Generic;

namespace Hotell
{
    public class Hotel
    {
        public Room room;
        public string Name;
        public List<Customer> customers = new List<Customer>();


        public Hotel(string name)
        {
            Name = name;
        }

        public Hotel()
        {
            room = new Room(this);
        }

        public Room bookRum()
        {
            Room roomNew = new Room();
            roomNew.RoomNR = ++room.RoomNR;
            roomNew.Occupied = true;

            Customer customer = new Customer();

            return room;
        }
    }
}
