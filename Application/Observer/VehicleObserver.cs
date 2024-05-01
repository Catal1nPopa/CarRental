using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.Observer
{
    public class VehicleObserver : IVehicleObserver
    {
        public void Update()
        {
            Console.WriteLine("Un nou vehicol adaugat");
        }
    }
}
