namespace Ejercicio25.model
{
    internal abstract class Party
    {
        private const double DECORATION_PRICE_PER_PERSON_STD = 7.5d;
        private const double DECORATION_PRICE_PER_PERSON_LUXE = 15.0d;
        private const double DECORATION_PRICE_STD = 30.0d;
        private const double DECORATION_PRICE_LUXE = 50.0d;
        private const double FIXED_COST_PERSON = 25.0d;

        public int NumberOfPeople { get; set; }
        public bool StyleDecorationStdOrLuxe { get; set; }

        protected Party() { }

        protected Party(int numberOfPeople, bool styleOfDecorationStdOrLuxe)
        {
            NumberOfPeople = numberOfPeople;
            StyleDecorationStdOrLuxe = styleOfDecorationStdOrLuxe;
        }

        protected double CalculateDecorationPrice()
        {
            return
                NumberOfPeople * ((StyleDecorationStdOrLuxe ? 
                     DECORATION_PRICE_PER_PERSON_LUXE
                    : DECORATION_PRICE_PER_PERSON_STD
                ) + FIXED_COST_PERSON)+
                (StyleDecorationStdOrLuxe ?
                    DECORATION_PRICE_LUXE : DECORATION_PRICE_STD
                );
        }
        public abstract double CalculatePrice();

    }
}
