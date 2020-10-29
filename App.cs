using AirplaneApplication.Models;
using System;

namespace AirplaneApplication
{
    public class App
    {
        private readonly Airplane _airplane = new Airplane();
        private readonly FoodCart _foodcart = new FoodCart();
        public void Run()
        {
            var menu = new Menu();

            while (true)
            {
                var menuSelection = menu.Show();
                switch (menuSelection)
                {
                    case MenuSelection.PassengerAdd:
                        var (firstName, lastName, age, seatNumber, passengerType) = menu.ShowBookingForm();
                        _airplane.AddPassenger(firstName, lastName, age, seatNumber, passengerType);
                        break;
                    case MenuSelection.PassengerRemove:
                        var passengerSeatNumber = menu.ShowIntInput("Enter seat number: ");
                        if (!_airplane.RemovePassenger(passengerSeatNumber))
                        {
                            Console.WriteLine("Seat unoccupied!");
                            break;
                        }
                        Console.WriteLine("Passenger removed!");
                        break;
                    case MenuSelection.OrderFood:
                        var (orderedFood, seatNumber) = menu.ShowOrderFoodMenu();
                        _foodcart.MakeFood(orderedFood);
                        break;
                    case MenuSelection.DeliverFood:
                        _foodcart.DeliverFood(menu.ShowIntInput("Enter seat number: "));
                        break;
                    case MenuSelection.Exit:
                        return;
                    case MenuSelection.Invalid:
                        continue;
                }
            }
        }
    }
}
