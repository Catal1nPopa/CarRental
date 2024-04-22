using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.DBRequests
{
    public class GetVehicle
    {
        public static List<VehicleList> GetAllVehicle(IVehicleRepository _vehicleRepository)
        {

            List<VehicleList> list = new List<VehicleList>();

            var hybridCars = _vehicleRepository.GetAllHybridCars().ToList();
            var electricCars = _vehicleRepository.GetAllElectricCars().ToList();
            var combustionCars = _vehicleRepository.GetAllCombustionCars().ToList();
            var electricMotorcycles = _vehicleRepository.GetAllElectricMotorcycles().ToList();
            var combustionMotorcycles = _vehicleRepository.GetAllCombustionMotorcycles().ToList();

            var vehicleList = new VehicleList(hybridCars, electricCars, combustionCars, electricMotorcycles, combustionMotorcycles);
            list.Add(vehicleList);

            return list;
        }
    }
}
