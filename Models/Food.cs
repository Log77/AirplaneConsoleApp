namespace AirplaneApplication.Models
{
    public abstract class Food
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Passenger Purchaser { get; set; }
        public abstract bool IsAllergen { get; set; }
        public abstract bool IsAlcohol { get; set; }
    }
}
