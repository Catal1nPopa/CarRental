using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarRentail.Application.DBRequests
{
    public class UpdateVehicle
    {

        public static bool UpdateVehicleData(IVehicleRepository _vehicleRepository, int id, Vehicle data, VehicleType.VehicleTypes vehicleType)
        {
         
            if (id != data.Id)
            {
                return false;
            }

            switch (vehicleType)
            {
                case VehicleType.VehicleTypes.CombustionCar:
                    var newData = new CombustionCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        State = data.State
                    };
                    _vehicleRepository.UpdateCombustionCar(newData);
                    
                    break;
                case VehicleType.VehicleTypes.CombustionMotorcycle:
                    //if (vehicle is CombustionMotorcycle combustionMotorcycle)
                    //{
                    //    _vehicleRepository.UpdateCombustionMotorcycle(combustionMotorcycle);
                    //}
                    break;
                case VehicleType.VehicleTypes.ElectricCar:
                    var newData2 = new ElectricCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        BatteryCapacity = data.BatteryCapacity,
                        State = data.State
                    };
                    _vehicleRepository.UpdateElectricCar(newData2);
                    
                    break;
                //case VehicleType.VehicleTypes.ElectricMotorcycle:
                //    if (vehicle is ElectricMotorcycle)
                //    {
                //        _vehicleRepository.UpdateElectricMotorcycle((ElectricMotorcycle)vehicle);
                //    }
                //    break;
                //case VehicleType.VehicleTypes.HybridCar:
                //    if (vehicle is HybridCar hybridCar)
                //    {
                //        _vehicleRepository.UpdateHybridCar(hybridCar);
                //    }
                    break;
                default:
                    // Handle unsupported vehicle types or throw an exception
                    throw new ArgumentException("Unsupported vehicle type.");
            }

            return true;
        }



        //public static bool UpdateCombustionCar(IVehicleRepository _vehicleRepository, int id, CombustionCar combustionCar)
        //{
        //    if (id != combustionCar.Id)
        //    {
        //        return false;
        //    }
        //    _vehicleRepository.UpdateCombustionCar(combustionCar);
        //    return true;
        //}

        //public static bool UpdateCombustionMotorcycle(IVehicleRepository _vehicleRepository, int id, CombustionMotorcycle combustionMotorcycle)
        //{
        //    if (id != combustionMotorcycle.Id)
        //    {
        //        return false;
        //    }
        //    _vehicleRepository.UpdateCombustionMotorcycle(combustionMotorcycle);
        //    return true;
        //}

        //public static bool UpdateElectricCar(IVehicleRepository _vehicleRepository, int id, ElectricCar electricCar)
        //{
        //    if (id != electricCar.Id)
        //    {
        //        return false;
        //    }
        //    _vehicleRepository.UpdateElectricCar(electricCar);
        //    return true;
        //}

        //public static bool UpdateeElectricMotor(IVehicleRepository _vehicleRepository, int id, ElectricMotorcycle electricMotorcycle)
        //{
        //    if (id != electricMotorcycle.Id)
        //    {
        //        return false;
        //    }
        //    _vehicleRepository.UpdateElectricMotorcycle(electricMotorcycle);
        //    return true;
        //}

        //public static bool UpdateHybridCar(IVehicleRepository _vehicleRepository, int id, HybridCar hybridCar)
        //{
        //    if (id != hybridCar.Id)
        //    {
        //        return false;
        //    }
        //    _vehicleRepository.UpdateHybridCar(hybridCar);
        //    return true;
        //}
    }
}
