using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25.model
{
    internal class Birthday : Party
    {
        String cakeText = "";
        bool sizeCake = false;
        const float LETTER_COST = 0.25f;
        const double PRICE_LITTLE_CAKE = 40;
        const double PRICE_BIG_CAKE = 75;
        public const int MAXIMUM_NUMBER_LETTERS_LITTLE = 16;
        public const int MAXIMUM_NUMBER_LETTERS_BIG = 40;
        public const int WHEN_IS_BIGGER = 8;

        public override double CalculatePrice()
        {
            

            throw new NotImplementedException();
        }
    }
}
