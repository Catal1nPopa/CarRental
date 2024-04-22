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
        //public static void AddCombustionCar(IVehicleRepository _vehicleRepository, CombustionCar data)
        //{
        //    _vehicleRepository.AddCombustionCar(data);
        //}

        //public static void AddElectricCar(IVehicleRepository _vehicleRepository, ElectricCar data)
        //{
        //    _vehicleRepository.AddElectricCar(data);
        //}
        //public static void AddHybridCar(IVehicleRepository _vehicleRepository, HybridCar data)
        //{
        //    _vehicleRepository.AddHybridCar(data);
        //}
        //public static void AddCombustionMotorcycle(IVehicleRepository _vehicleRepository, CombustionMotorcycle data)
        //{
        //    _vehicleRepository.AddCombustionMotorcycle(data);
        //}
        //public static void AddElectricMotorcycle(IVehicleRepository _vehicleRepository, ElectricMotorcycle data)
        //{
        //    _vehicleRepository.AddElectricMotorcycle(data);
        //}

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
                    // Handle unsupported vehicle types or throw an exception
                    throw new ArgumentException("Unsupported vehicle type.");
            }
        }
    }
}
