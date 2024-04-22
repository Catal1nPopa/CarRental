using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using CarRentail.Infrastructure.Context;

namespace CarRentail.Infrastructure.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Implementarea pentru HybridCar
        public IEnumerable<HybridCar> GetAllHybridCars()
        {
            return _context.HybridCars.ToList();
        }

        public HybridCar GetHybridCarById(int id)
        {
            return _context.HybridCars.FirstOrDefault(v => v.Id == id);
        }

        public void AddHybridCar(HybridCar hybridCar)
        {
            _context.Add(hybridCar);
            _context.SaveChanges();
        }

        public void UpdateHybridCar(HybridCar hybridCar)
        {
            _context.Update(hybridCar);
            _context.SaveChanges();
        }

        public void DeleteHybridCar(int id)
        {
            var hybridCar = GetHybridCarById(id);
            if (hybridCar != null)
            {
                _context.Remove(hybridCar);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ElectricCar> GetAllElectricCars()
        {
            return _context.ElectricCars.ToList();
        }

        public ElectricCar GetElectricCarById(int id)
        {
            return _context.ElectricCars.FirstOrDefault(v => v.Id == id);
        }

        public void AddElectricCar(ElectricCar electricCar)
        {
            _context.Add(electricCar);
            _context.SaveChanges();
        }

        public void UpdateElectricCar(ElectricCar electricCar)
        {
            _context.Update(electricCar);
            _context.SaveChanges();
        }

        public void DeleteElectricCar(int id)
        {
            var electriCar = GetHybridCarById(id);
            if (electriCar != null)
            {
                _context.Remove(electriCar);
                _context.SaveChanges();
            }
        }

        public IEnumerable<CombustionCar> GetAllCombustionCars()
        {
            return _context.CombustionCars.ToList();
        }

        public CombustionCar GetCombustionCarById(int id)
        {
            return _context.CombustionCars.FirstOrDefault(v => v.Id == id);
        }

        public void AddCombustionCar(CombustionCar combustionCar)
        {
            _context.Add(combustionCar);
            _context.SaveChanges();
        }

        public void UpdateCombustionCar(CombustionCar combustionCar)
        {
            _context.Update(combustionCar);
            _context.SaveChanges();
        }

        public void DeleteCombustionCar(int id)
        {
            var combustionCar = GetHybridCarById(id);
            if (combustionCar != null)
            {
                _context.Remove(combustionCar);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ElectricMotorcycle> GetAllElectricMotorcycles()
        {
            return _context.ElectricMotorcycles.ToList();
        }

        public ElectricMotorcycle GetElectricMotorcycleById(int id)
        {
            return _context.ElectricMotorcycles.FirstOrDefault(v => v.Id == id);
        }

        public void AddElectricMotorcycle(ElectricMotorcycle electricMotorcycle)
        {
            _context.Add(electricMotorcycle);
            _context.SaveChanges();
        }

        public void UpdateElectricMotorcycle(ElectricMotorcycle electricMotorcycle)
        {
            _context.Update(electricMotorcycle);
            _context.SaveChanges();
        }

        public void DeleteElectricMotorcycle(int id)
        {
            var electricMotorcycle= GetHybridCarById(id);
            if (electricMotorcycle != null)
            {
                _context.Remove(electricMotorcycle);
                _context.SaveChanges();
            }
        }

        public IEnumerable<CombustionMotorcycle> GetAllCombustionMotorcycles()
        {
            return _context.CombustionMotorcycles.ToList();
        }

        public CombustionMotorcycle GetCombustionMotorcycleById(int id)
        {
            return _context.CombustionMotorcycles.FirstOrDefault(v => v.Id == id);
        }

        public void AddCombustionMotorcycle(CombustionMotorcycle combustionMotorcycle)
        {
            _context.Add(combustionMotorcycle);
            _context.SaveChanges();
        }

        public void UpdateCombustionMotorcycle(CombustionMotorcycle combustionMotorcycle)
        {
            _context.Update(combustionMotorcycle);
            _context.SaveChanges();
        }

        public void DeleteCombustionMotorcycle(int id)
        {
            var combustionMotorcycle = GetHybridCarById(id);
            if (combustionMotorcycle != null)
            {
                _context.Remove(combustionMotorcycle);
                _context.SaveChanges();
            }
        }
    }
}
