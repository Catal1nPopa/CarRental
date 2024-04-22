using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.DBRequests
{
    public class UpdateVehicle
    {
        public static bool UpdateCombustionCar(IVehicleRepository _vehicleRepository, int id, CombustionCar combustionCar)
        {
            if (id != combustionCar.Id)
            {
                return false;
            }
            _vehicleRepository.UpdateCombustionCar(combustionCar);
            return true;
        }

        public static bool UpdateCombustionMotorcycle(IVehicleRepository _vehicleRepository, int id, CombustionMotorcycle combustionMotorcycle)
        {
            if (id != combustionMotorcycle.Id)
            {
                return false;
            }
            _vehicleRepository.UpdateCombustionMotorcycle(combustionMotorcycle);
            return true;
        }

        public static bool UpdateElectricCar(IVehicleRepository _vehicleRepository, int id, ElectricCar electricCar)
        {
            if (id != electricCar.Id)
            {
                return false;
            }
            _vehicleRepository.UpdateElectricCar(electricCar);
            return true;
        }

        public static bool UpdateeElectricMotor(IVehicleRepository _vehicleRepository, int id, ElectricMotorcycle electricMotorcycle)
        {
            if (id != electricMotorcycle.Id)
            {
                return false;
            }
            _vehicleRepository.UpdateElectricMotorcycle(electricMotorcycle);
            return true;
        }

        public static bool UpdateHybridCar(IVehicleRepository _vehicleRepository, int id, HybridCar hybridCar)
        {
            if (id != hybridCar.Id)
            {
                return false;
            }
            _vehicleRepository.UpdateHybridCar(hybridCar);
            return true;
        }
    }
}
