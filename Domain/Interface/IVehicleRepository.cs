using CarRentail.Domain.Entities;
using CarRentail.Domain.Entities.Auth;

namespace CarRentail.Domain.Interface
{
    public interface IVehicleRepository
    {
        IEnumerable<HybridCar> GetAllHybridCars();
        HybridCar GetHybridCarById(int id);
        void AddHybridCar(HybridCar hybridCar);
        void UpdateHybridCar(HybridCar hybridCar);
        void DeleteHybridCar(int id);

        IEnumerable<ElectricCar> GetAllElectricCars();
        ElectricCar GetElectricCarById(int id);
        void AddElectricCar(ElectricCar electricCar);
        void UpdateElectricCar(ElectricCar electricCar);
        void DeleteElectricCar(int id);

        IEnumerable<CombustionCar> GetAllCombustionCars();
        CombustionCar GetCombustionCarById(int id);
        void AddCombustionCar(CombustionCar combustionCar);
        void UpdateCombustionCar(CombustionCar combustionCar);
        void DeleteCombustionCar(int id);

        IEnumerable<ElectricMotorcycle> GetAllElectricMotorcycles();
        ElectricMotorcycle GetElectricMotorcycleById(int id);
        void AddElectricMotorcycle(ElectricMotorcycle electricMotorcycle);
        void UpdateElectricMotorcycle(ElectricMotorcycle electricMotorcycle);
        void DeleteElectricMotorcycle(int id);

        IEnumerable<CombustionMotorcycle> GetAllCombustionMotorcycles();
        CombustionMotorcycle GetCombustionMotorcycleById(int id);
        void AddCombustionMotorcycle(CombustionMotorcycle combustionMotorcycle);
        void UpdateCombustionMotorcycle(CombustionMotorcycle combustionMotorcycle);
        void DeleteCombustionMotorcycle(int id);

        void AddCarInspection (CarInspection carInspection);
        List<CarInspection> GetAllInspections();

         List<RentalProc> GetAllRentals();
        void AddRentalRegistration(RentalProc  rentalRegistration);
        void UpdateRentakRegistration(RentalProc  rentalRegistration);

        //Users

        void AddUser(User user);
        User GetUser(User user);

        void UpdateUser(User user);

        //Clients
        void AddClient(Client client);
        void UpdateClientRentals(int client);
        Client GetClient(Client client);

    }
}
