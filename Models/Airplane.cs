using System;
using System.Collections.Generic;
using System.Linq;

namespace AirplaneApplication
{
    public class Airplane
    {
        public List<Passenger> Passengers { get; } = new List<Passenger>();

        public bool AddPassenger(string firstName, string lastName, int age, int seatNumber, PassengerType passengerType)
        {
            if (Passengers.Exists(p => p.SeatNumber == seatNumber))
            {
                return false;
            }

            var passenger = new Passenger
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                SeatNumber = seatNumber,
                PassengerType = passengerType
            };
            Passengers.Add(passenger);
            return true;
        }

        public bool RemovePassenger(int seatNumber)
        {
            Passenger passengerToRemove = Passengers.Find(p => p.SeatNumber == seatNumber);
            if (passengerToRemove == null)
            {
                return false;
            }
            Passengers.Remove(passengerToRemove);
            return true;
        }
    }
}
