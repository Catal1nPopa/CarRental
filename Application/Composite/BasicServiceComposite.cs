using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.Composite
{
    // Reprezintă o frunză în structura Composite (o serviciu atomic, nu compus)
    public class BasicServiceComposite : IServiceComponent
    {
        private string _serviceName;
        private decimal _price;

        public BasicServiceComposite(string serviceName, decimal price)
        {
            _serviceName = serviceName;
            _price = price;
        }

        public void PerformService()
        {
            Console.WriteLine($"Se efectuează serviciul: {_serviceName} la prețul de {_price}.");
        }
    }
}
