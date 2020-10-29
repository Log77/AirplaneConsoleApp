using System;

namespace AirplaneApplication
{
    public class Menu
    {
        public MenuSelection Show()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("(1) Add passenger");
            Console.WriteLine("(2) Remove passenger");
            Console.WriteLine("(3) Order food");
            Console.WriteLine("(4) Deliver food");
            Console.WriteLine("(5) Exit");
            Console.Write("\r\nSelect an option: ");

            return (Console.ReadLine()) switch
            {
                "1" => MenuSelection.PassengerAdd,
                "2" => MenuSelection.PassengerRemove,
                "3" => MenuSelection.OrderFood,
                "4" => MenuSelection.DeliverFood,
                "5" => MenuSelection.Exit,
                _ => MenuSelection.Invalid,
            };
        }

        public int ShowIntInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                if (int.TryParse(input, out var result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input!");
            }
        }

        public (string firstName, string lastName, int age, int seatNumber, PassengerType passengerType) ShowBookingForm()
        {
            Console.Write("Enter first name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            var lastName = Console.ReadLine();

            var age = ShowIntInput("Enter age: ");
            var seatNumber = ShowIntInput("Enter seat number: ");
            var passengerType = ShowPassengerTypeInput();

            return (firstName, lastName, age, seatNumber, passengerType);
        }

        private PassengerType ShowPassengerTypeInput()
        {
            while (true)
            {
                Console.WriteLine("Select passenger type:");
                Console.WriteLine("(1) Adult");
                Console.WriteLine("(2) Child");
                Console.WriteLine("(3) Staff");
                PassengerType? passengerType = (Console.ReadLine()) switch
                {
                    "1" => PassengerType.Adult,
                    "2" => PassengerType.Child,
                    "3" => PassengerType.Staff,
                    _ => null
                };
                if (passengerType is PassengerType notNullPassengerType)
                {
                    return notNullPassengerType;
                }
                Console.WriteLine("Invalid passenger type!"); 
            }
        }

        public (FoodSelection selection, int seatNumber) ShowOrderFoodMenu()
        {
            while (true)
            {
                Console.WriteLine("Select food:");
                Console.WriteLine("(1) Meatballs");
                Console.WriteLine("(2) Gruel");
                Console.WriteLine("(3) Peanuts");
                Console.WriteLine("(4) Wine");
                FoodSelection? foodSelection = (Console.ReadLine()) switch
                {
                    "1" => FoodSelection.Meatballs,
                    "2" => FoodSelection.Gruel,
                    "3" => FoodSelection.Peanuts,
                    "4" => FoodSelection.Wine,
                    _ => null
                };
                if (foodSelection is FoodSelection notNullSelection)
                {
                    var seatNumber = ShowIntInput("Enter seat number: ");
                    Console.WriteLine("You food will arrive soon!");
                    return (notNullSelection, seatNumber);
                }
                Console.WriteLine("That menu item does not exist!");
            }
        }
    }
}
