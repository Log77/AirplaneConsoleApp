using System;
using System.Collections.Generic;

namespace AirplaneApplication
{
    class Airplane
    {
        public List<Passenger> Passengers { get; set; }

        public void AddPassenger()
        {
            Passenger passenger = new Passenger();

            Console.Clear();
            Console.Write("\r\nEnter first name: ");
            passenger.FirstName = Console.ReadLine();

            Console.Clear();
            Console.Write("\r\nEnter last name: ");
            passenger.LastName = Console.ReadLine();

            Console.Clear();
            Console.Write("\r\nEnter age: ");
            passenger.Age = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.Write("\r\nEnter seat number: ");
            passenger.SeatNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Select passenger type:");
            Console.WriteLine("(1) Adult");
            Console.WriteLine("(2) Child");
            Console.WriteLine("(3) Staff");
            switch (Console.ReadLine())
            {
                case "1":
                    passenger.Type = "Adult";
                    break;
                case "2":
                    passenger.Type = "Child";
                    break;
                case "3":
                    passenger.Type = "Staff";
                    break;
            }
            Console.Clear();
            Passengers.Add(passenger);
            Console.Write("Passenger created!");
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        public void RemovePassenger(int seatNumber)
        {
            Passenger passengerToRemove = Passengers.Find(p => p.SeatNumber == seatNumber);
            if (passengerToRemove == null)
            {
                Console.Write("No passenger found! ");
                Console.Write("Press enter to continue...");
                Console.ReadLine();
            }
            else
            {
                Passengers.Remove(passengerToRemove);
                Console.Write("Passenger removed! ");
                Console.Write("Press enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
