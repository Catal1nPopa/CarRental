using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;

namespace CarRentail.Domain.Interface
{
    public interface IVehicleObserver
    {
        void Update();
    }
}
