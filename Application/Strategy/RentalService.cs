using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Strategy
{
    public class RentalService
    {
        private readonly StandardPricingStrategy _standardPricingStrategy;
        private readonly PremiumPricingStrategy _premiumPricingStrategy;

        public RentalService(StandardPricingStrategy standardPricingStrategy, PremiumPricingStrategy premiumPricingStrategy)
        {
            _standardPricingStrategy = standardPricingStrategy;
            _premiumPricingStrategy = premiumPricingStrategy;
        }

        public int CalculateRentalPrice(int days)
        {
            if (days <= 30)
            {
                return _standardPricingStrategy.CalculateRentalPrice(days);
            }
            else
            {
                return _premiumPricingStrategy.CalculateRentalPrice(days);
            }
        }
    }
}
