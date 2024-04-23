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
        public static void AddVehicleNew(IVehicleRepository _vehicleRepository, IVehicle data, VehicleType.VehicleTypes vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.VehicleTypes.CombustionCar:
                    _vehicleRepository.AddCombustionCar((CombustionCar)data);
                    break;
                case VehicleType.VehicleTypes.ElectricCar:
                    _vehicleRepository.AddElectricCar((ElectricCar)data);
                    break;
                case VehicleType.VehicleTypes.HybridCar:
                    _vehicleRepository.AddHybridCar((HybridCar)data);
                    break;
                case VehicleType.VehicleTypes.CombustionMotorcycle:
                    _vehicleRepository.AddCombustionMotorcycle((CombustionMotorcycle)data);
                    break;
                case VehicleType.VehicleTypes.ElectricMotorcycle:
                    _vehicleRepository.AddElectricMotorcycle((ElectricMotorcycle)data);
                    break;
                default:
                    throw new ArgumentException("Unsupported vehicle type.");
            }
        }
    }
}
