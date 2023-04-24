using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25.model
{
    internal class Dinners : Party
    {
        private bool healthyOption = false;
        private const double COST_DRINK_ALCOHOL= 20;
        private const double COST_HEALTHY_DRINK = 5;
        private const int DISCOUNT_FOR_HEALTHY = 5;


        public override double CalculatePrice()
        {
            double price = CalculateDecorationPrice() + CalculateHealthyOptionPrice();

            return healthyOption? price*Discount(): price;
              
        }

        private double CalculateHealthyOptionPrice()
        {
            return NumOfPeople*(!healthyOption ? COST_DRINK_ALCOHOL : COST_HEALTHY_DRINK);
        }

        private double Discount()
        {
            return (1 - DISCOUNT_FOR_HEALTHY / 100);
        }
    }

    
}
