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
                        CarNumber = data.CarNumber,
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
                    var comMoto = new CombustionMotorcycle
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        State = data.State
                    };
                    _vehicleRepository.UpdateCombustionMotorcycle(comMoto);
                    break;
                case VehicleType.VehicleTypes.ElectricCar:
                    var newData2 = new ElectricCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
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
                case VehicleType.VehicleTypes.ElectricMotorcycle:
                    var carElec = new ElectricMotorcycle
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        BatteryCapacity = data.BatteryCapacity,
                        State = data.State
                    };
                    _vehicleRepository.UpdateElectricMotorcycle(carElec);
                    break;
                case VehicleType.VehicleTypes.HybridCar:
                    var hybrid = new HybridCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        ElectricPower = data.ElectricPower,
                        State = data.State
                    };
                    _vehicleRepository.UpdateHybridCar(hybrid);
                    break;
                default:
                    throw new ArgumentException("Unsupported vehicle type.");
            }
            return true;
        }
    }
}
