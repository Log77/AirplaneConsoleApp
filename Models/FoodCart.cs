using System;
using System.Collections.Generic;

namespace AirplaneApplication.Models
{
    public class FoodCart
    {
        public List<Food> FoodsToBeDelivered = new List<Food>();
        public List<int> CartLocation = new List<int>();

        public Food MakeFood(FoodSelection foodSelection)
        {
            var food = foodSelection switch
            {
            };
            switch (menuSelection)
            {
                case MenuSelection.Meatballs:
                    return new Meatballs();
                case MenuSelection.Gruel:
                    return new Gruel();
                case MenuSelection.Wine:
                    return new Wine();
                case MenuSelection.Peanuts:
                    return new Peanuts();
            }
        }

        public void DeliverFood(int seatNumber)
        {
            CartLocation.Add(seatNumber);
        }
    }
}
