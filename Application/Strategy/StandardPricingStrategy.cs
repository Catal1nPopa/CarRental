using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Strategy
{
    public class StandardPricingStrategy : IPricingStrategy
    {
        public int CalculateRentalPrice(int days)
        {
            return days * 50;
        }
    }
}
