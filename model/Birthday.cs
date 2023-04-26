namespace Ejercicio25.model
{
    internal class Birthday : Party
    {
        public const int MAXIMUM_NUMBER_LETTERS_LITTLE = 16;
        public const int MAXIMUM_NUMBER_LETTERS_BIG = 40;
        public const int WHEN_IS_BIGGER = 8;

        private const float LETTER_COST = 0.25f;
        private const int PRICE_LITTLE_CAKE = 40;
        private const int PRICE_BIG_CAKE = 75;
        
        private string cakeText = "";

        public string CakeText { get => cakeText; set => cakeText = value; }

        public Birthday() : base() { } 

        public Birthday(int numberOfPeople, bool styleOfDecorationStdOrLuxe, string cakeText) : base(numberOfPeople, styleOfDecorationStdOrLuxe)
        {
            CakeText = cakeText;
        }

        public override double CalculatePrice() => CalculateDecorationPrice() + PriceOfCake();

        private double PriceOfCake() => PriceForTypeOfCake() + PriceOfLetterOnTheCake();

        private int PriceForTypeOfCake() => NumberOfPeople > 8 ? PRICE_BIG_CAKE : PRICE_LITTLE_CAKE;

        private double PriceOfLetterOnTheCake() => CakeText.Length * LETTER_COST;
    }
}
