using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.DBRequests
{
    public class GetById
    {
        public static object GetVehicle(IVehicleRepository _vehicleRepository, int id, VehicleType.VehicleTypes types)
        {
            switch (types)
            {
                case VehicleType.VehicleTypes.HybridCar:
                    return _vehicleRepository.GetHybridCarById(id);
                case VehicleType.VehicleTypes.CombustionCar:
                    return _vehicleRepository.GetCombustionCarById(id);
                case VehicleType.VehicleTypes.ElectricCar:
                    return _vehicleRepository.GetElectricCarById(id);
                case VehicleType.VehicleTypes.ElectricMotorcycle:
                    return _vehicleRepository.GetElectricMotorcycleById(id);
                case VehicleType.VehicleTypes.CombustionMotorcycle:
                    return _vehicleRepository.GetCombustionMotorcycleById(id);
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
