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
        public static object GetVehicle(IVehicleRepository _vehicleRepository, int id,string  types)
        {
            switch (types)
            {
                case "0":
                    return _vehicleRepository.GetHybridCarById(id);
                case "1":
                    return _vehicleRepository.GetCombustionCarById(id);
                case "2":
                    return _vehicleRepository.GetElectricCarById(id);
                case "3":
                    return _vehicleRepository.GetElectricMotorcycleById(id);
                case "4":
                    return _vehicleRepository.GetCombustionMotorcycleById(id);
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
