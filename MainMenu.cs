using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneApplication
{
    class MainMenu
    {
        public static bool DisplayMainMenu()
        {
            Airplane airplane = new Airplane
            {
                Passengers = new List<Passenger>()
            };

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("(1) Add passenger");
            Console.WriteLine("(2) Remove passenger");
            Console.WriteLine("(3) Test");
            Console.WriteLine("(4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    airplane.AddPassenger();
                    return true;
                case "2":
                    Console.Clear();
                    Console.Write("\r\nEnter seat number: ");
                    airplane.RemovePassenger(Convert.ToInt32(Console.ReadLine()));
                    return true;
                case "3":
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }
    }
}
