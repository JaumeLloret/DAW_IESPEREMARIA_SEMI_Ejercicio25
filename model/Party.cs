using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25.model
{
    internal abstract class Party
    {
        
        const double DECORATION_PRICE_PER_PERSON_STD = 7.5d;
        const double DECORATION_PRICE_PER_PERSON_LUXE = 15.0d;
        const double DECORATION_PRICE_STD = 30.0d;
        const double DECORATION_PRICE_LUXE = 50.0d;
        const double FIXED_COST_PERSON = 25.0d;

        protected int NumOfPeople { get; set; }
        bool IsDecorationStdOrLuxe { get; set; }

        public double CalculateDecorationPrice()
        {
            return
                NumOfPeople * ((IsDecorationStdOrLuxe ? 
                     DECORATION_PRICE_PER_PERSON_LUXE
                    : DECORATION_PRICE_PER_PERSON_STD
                ) + FIXED_COST_PERSON)+
                (IsDecorationStdOrLuxe ?
                    DECORATION_PRICE_LUXE : DECORATION_PRICE_STD
                );
        }
        public abstract double CalculatePrice();

    }
}
