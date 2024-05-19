using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;

namespace CarRentail.Domain.Interface
{
    public interface ICarRentalFacade
    {
        void AddVehicleData(IVehicle data, string vehicleTypes);
        void RemoveVehicle(int id, VehicleType.VehicleTypes types);
        object GetVehicleById(int id, string types);
        List<VehicleList> getAllVehicles();
        bool UpdateVehicles(int id, Vehicle data, VehicleType.VehicleTypes vehicleTypes);

        void AddInspectionCar(CarInspection carInspection, CarInspectionEnum typeInspection);
        List<CarInspection> GetAllInspectionCars();

        HybridCar getHybridCars(int id);
        ElectricCar getElectricCars(int id);
        CombustionCar getCombustionCars(int id);
        ElectricMotorcycle getElectricMotorcycles(int id);
        CombustionMotorcycle getCombustionMotorcycles(int id);
        List<Client> getAllClients();
        Client getClient(string name);
        bool UpdatePhoneNumber(int idClient, string phoneNumber);

        void deleteRental(int id);

        List<RentalProc> getRentalsCustomer(int id);

    }
}
