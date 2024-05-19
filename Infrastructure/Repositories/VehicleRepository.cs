using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Entities.Auth;
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
            try
            {
                var hybridCar2 = _context.HybridCars.Find(hybridCar.Id);

                if (hybridCar2 != null)
                {
                    if (hybridCar2.State)
                    {
                        hybridCar2.State = false;
                    }
                    else
                    {
                        hybridCar2.State = true;
                    }
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" car not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            try
            {
                var electricCar2 = _context.ElectricCars.Find(electricCar.Id);

                if (electricCar2 != null)
                {
                    if (electricCar2.State)
                    {
                        electricCar2.State = false;
                    }
                    else
                    {
                        electricCar2.State = true;
                    }
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" car not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteElectricCar(int id)
        {
            var electriCar = GetElectricCarById(id);
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
            try
            {
                var combustionCar2 = _context.CombustionCars.Find(combustionCar.Id);

                if (combustionCar2 != null)
                {
                    if (combustionCar2.State)
                    {
                        combustionCar2.State = false;
                    }
                    else
                    {
                        combustionCar2.State = true;
                    }
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" car not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCombustionCar(int id)
        {
            var combustionCar = GetCombustionCarById(id);
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
            try
            {
                var electricMotorcycle2 = _context.ElectricMotorcycles.Find(electricMotorcycle.Id);

                if (electricMotorcycle2 != null)
                {
                    if (electricMotorcycle2.State)
                    {
                        electricMotorcycle2.State = false;
                    }
                    else
                    {
                        electricMotorcycle2.State = true;
                    }
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" motorcycle not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteElectricMotorcycle(int id)
        {
            var electricMotorcycle= GetElectricMotorcycleById(id);
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
            try
            {
                var combustionMotorcycle2 = _context.CombustionMotorcycles.Find(combustionMotorcycle.Id);

                if (combustionMotorcycle2 != null)
                {
                    if (combustionMotorcycle2.State)
                    {
                        combustionMotorcycle2.State = false;
                    }
                    else
                    {
                        combustionMotorcycle2.State = true;
                    }
                    _context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" motorcycle not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCombustionMotorcycle(int id)
        {
            var combustionMotorcycle = GetCombustionMotorcycleById(id);
            if (combustionMotorcycle != null)
            {
                _context.Remove(combustionMotorcycle);
                _context.SaveChanges();
            }
        }

        public void AddCarInspection(CarInspection carInspection)
        {
            _context.Add(carInspection);
            _context.SaveChanges();
        }

        public List<CarInspection> GetAllInspections()
        {
            return _context.CarInspections.ToList();
        }

        public List<RentalProc> GetAllRentals()
        {
           return  _context.RentalRegistration.ToList();
        }

        //rental 
        public void AddRentalRegistration(RentalProc rentalProc)
        {
            _context.Add(rentalProc);
            _context.SaveChanges();
        }

        public List<RentalProc> GetRentalsByCustomer(int id)
        {
            var rentals = GetAllRentals();
            List<RentalProc> rental = new List<RentalProc>();

            foreach (var rent in rentals)
            {
                if(rent.CustomerId.Equals(id))
                    rental.Add(rent);
            }
            return rental;
        }
        public void UpdateRentakRegistration(RentalProc rentalProc)
        {
            _context.Update(rentalProc);
            _context.SaveChanges();
        }

        public RentalProc GetRentalProcById(int id)
        {
           return _context.RentalRegistration.FirstOrDefault(v => v.Id == id);
        }
        public void DeleteRentalRegistration(int id)
        {
            var rentalById = GetRentalProcById(id);
            _context.Remove(rentalById);
            _context.SaveChanges();
        }

        
        public void AddUser(User dataUser)
        {
            _context.Users.Add(dataUser);
            _context.SaveChanges();
        }

        public User GetUser(User dataUser)
        {
           return _context.Users.FirstOrDefault(v => v.username == dataUser.username);
        }

        public void UpdateUser(User dataUser)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.Id == dataUser.Id);

            if (userToUpdate != null)
            {
                userToUpdate.password = dataUser.password;

                _context.SaveChanges();
            }
        }

        public void UpdateRoleUser(User dataUser)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.Id == dataUser.Id);

            if (userToUpdate != null)
            {
                userToUpdate.role = dataUser.role;
                _context.SaveChanges();
            }
        }

        //clients

        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClientRentals(int client)
        {
            var clientToUpdate = _context.Clients.FirstOrDefault(u => u.Id == client);
            if (clientToUpdate != null)
            {
                clientToUpdate.rentalCars++;
                _context.SaveChanges();
            }
        }

        public void UpdateClientPhone(int client, string phoneNumber)
        {
            var clientToUpdate = _context.Clients.FirstOrDefault(u => u.Id == client);
            if (clientToUpdate != null)
            {
                clientToUpdate.PhoneNumber = phoneNumber;
                _context.SaveChanges();
            }
        }

        public Client? GetClient(string Name)
        {
            return _context.Clients.FirstOrDefault(v => v.Name == Name);
        }

        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }
    }
}