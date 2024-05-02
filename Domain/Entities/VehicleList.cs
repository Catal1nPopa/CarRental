using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Domain.Entities
{
    public class VehicleList
    {
        public List<HybridCar> HybridCars { get; set; }
        public List<ElectricCar> HyElectricCars { get; set; }
        public List<CombustionCar> CombustionCars{ get; set; }
        public List<ElectricMotorcycle> ElectricMotorcycle { get; set; }
        public List<CombustionMotorcycle> CombustionMotorcycles { get; set; }

        public VehicleList(List<HybridCar> hybridCars, List<ElectricCar> hyElectricCars, List<CombustionCar> combustionCars, List<ElectricMotorcycle> electricMotorcycle, List<CombustionMotorcycle> combustionMotorcycles)
        {
            HybridCars = hybridCars;
            HyElectricCars = hyElectricCars;
            CombustionCars = combustionCars;
            ElectricMotorcycle = electricMotorcycle;    
            CombustionMotorcycles = combustionMotorcycles;
        }
    }
}
