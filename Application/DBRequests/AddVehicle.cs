using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;

namespace CarRentail.Application.DBRequests
{
    public class AddVehicle
    {
        public static void AddCombustionCar(IVehicleRepository _vehicleRepository, CombustionCar data)
        {
            _vehicleRepository.AddCombustionCar(data);
        }

        public static void AddElectricCar(IVehicleRepository _vehicleRepository, ElectricCar data)
        {
            _vehicleRepository.AddElectricCar(data);
        }
        public static void AddHybridCar(IVehicleRepository _vehicleRepository, HybridCar data)
        {
            _vehicleRepository.AddHybridCar(data);
        }
        public static void AddCombustionMotorcycle(IVehicleRepository _vehicleRepository, CombustionMotorcycle data)
        {
            _vehicleRepository.AddCombustionMotorcycle(data);
        }
        public static void AddElectricMotorcycle(IVehicleRepository _vehicleRepository, ElectricMotorcycle data)
        {
            _vehicleRepository.AddElectricMotorcycle(data);
        }
    }
}
