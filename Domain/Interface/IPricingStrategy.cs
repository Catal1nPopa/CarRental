using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Interface
{
    public interface IPricingStrategy
    {
        int CalculateRentalPrice(int days);
    }
}
