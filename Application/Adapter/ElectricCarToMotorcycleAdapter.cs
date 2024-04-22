using CarRentail.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.Adapter
{
    // Adaptorul pentru a converti un ElectricCar într-un ElectricMotorcycle
    public class ElectricCarToMotorcycleAdapter : IVehicleAdapter
    {
        public IVehicle Adapt(IVehicle vehicle)
        {
            ElectricCar electricCar = (ElectricCar)vehicle;
            ElectricMotorcycle electricMotorcycle = new ElectricMotorcycle
            {
                Id = electricCar.Id,
                Brand = electricCar.Brand,
                Model = electricCar.Model,
                Year = electricCar.Year,
                Distance = electricCar.Distance,
                Photo = electricCar.Photo,
                Price = electricCar.Price,
                EnginePower = electricCar.EnginePower,
                BatteryCapacity = electricCar.BatteryCapacity,
                State = electricCar.State
            };

            return electricMotorcycle;
        }
    }

}
