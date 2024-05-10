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
        public static void AddVehicleNew(IVehicleRepository _vehicleRepository, IVehicle data, string vehicleType)
        {
            switch (vehicleType)
            {
                case "1":
                    _vehicleRepository.AddCombustionCar((CombustionCar)data);
                    break;
                case "2":
                    _vehicleRepository.AddElectricCar((ElectricCar)data);
                    break;
                case "0":
                    _vehicleRepository.AddHybridCar((HybridCar)data);
                    break;
                case "4":
                    _vehicleRepository.AddCombustionMotorcycle((CombustionMotorcycle)data);
                    break;
                case "3":
                    _vehicleRepository.AddElectricMotorcycle((ElectricMotorcycle)data);
                    break;
                default:
                    throw new ArgumentException("Unsupported vehicle type.");
            }
        }
    }
}
