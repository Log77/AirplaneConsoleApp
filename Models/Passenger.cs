using AirplaneApplication.Models;
using System;

namespace AirplaneApplication
{
    public class Passenger
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public PassengerType PassengerType { get; set; }
        public int SeatNumber { get; set; }

        public Food OrderFood(String seatNumber)
        {
            var item = new Food();

            return item;
        }
    }
}
