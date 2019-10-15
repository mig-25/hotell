using System;
namespace Hotell
{
    public class Room
    {
        public int RoomNR = 99;
        public string Beds;
        private Hotel hotel;
        private bool occupied = false;

        public Room()
        {
        }

        public Room(Hotel hotel)
        {
            this.hotel = hotel;
        }

        public bool Occupied
        {
            get
            {
                return occupied;
            }
            set
            {
                occupied = value;
            }
        }


    }
}
