using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Domain.Entities
{
    public class VehicleList : IEnumerable<IVehicle>
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

        public IEnumerator<IVehicle> GetEnumerator()
        {
            foreach (var hybridCar in HybridCars)
            {
                yield return hybridCar;
            }

            foreach (var electricCar in HyElectricCars)
            {
                yield return electricCar;
            }

            foreach (var combustionCar in CombustionCars)
            {
                yield return combustionCar;
            }

            foreach (var electricMotorcycle in ElectricMotorcycle)
            {
                yield return electricMotorcycle;
            }

            foreach (var combustionMotorcycle in CombustionMotorcycles)
            {
                yield return combustionMotorcycle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
