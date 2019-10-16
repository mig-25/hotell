using System;
using System.Collections.Generic;

namespace Hotell
{
    public class Hotel
    {

        public Room room;//Composit relation to room
        public string hotelName;
        public static List<Customer> CustomersList = new List<Customer>();//aggregation relation to Customers

        public static int customerNumberMarker = 1000;

        public Hotel(string name)
        {
            hotelName = name;
        }

        public Hotel()
        {
            room = new Room(this);
        }

        public Room bookRum()
        {

            Customer customer = new Customer();//assocition relation to Customer
            Console.WriteLine("Enter Customer Name");
            customer.Name = Console.ReadLine();
            customer.CustomerId = ++customerNumberMarker;

            CustomersList.Add(customer);

            foreach (Customer customers in CustomersList)
            {
                Console.WriteLine($"CustomerID Created: {customer.CustomerId} created for Customer name: {customer.Name}");
            }


            Room roomNew = new Room();
            roomNew.RoomNR = ++room.RoomNR;
            roomNew.Occupied = true;
            Console.WriteLine($"Room nr booked: {roomNew.RoomNR}, Booking status: {roomNew.Occupied}");


            //Console.WriteLine($"Loyalty bonus: {customer.bonus()}");

            return room;
        }



        

    }
}
