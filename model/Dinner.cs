namespace Ejercicio25.model
{
    internal class Dinner : Party
    {
        private const double COST_DRINK_ALCOHOL= 20;
        private const double COST_HEALTHY_DRINK = 5;
        private const int DISCOUNT_FOR_HEALTHY = 5;

        private bool healthyOption = false;

        public bool HealthyOption { get => healthyOption; set => healthyOption = value; }

        public Dinner() : base() { }

        public Dinner(int numberOfPeople, bool styleOfDecorationStdOrLuxe, bool healthyOption)
            : base(numberOfPeople, styleOfDecorationStdOrLuxe)
        {
            HealthyOption = healthyOption;
        }

        public override double CalculatePrice()
        {
            double price = CalculateDecorationPrice() + CalculateHealthyOptionPrice();

            return HealthyOption ? price * Discount() : price;
        }

        private double CalculateHealthyOptionPrice()
        {
            return NumberOfPeople * (!HealthyOption ? COST_DRINK_ALCOHOL : COST_HEALTHY_DRINK);
        }

        private static double Discount() => 1 - DISCOUNT_FOR_HEALTHY / 100;
    }

    
}
