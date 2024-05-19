using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities.Auth;
using CarRentail.Domain.Enums;
using CarRentail.Infrastructure.Repositories;

namespace CarRentail.Application.Facade
{
    public class CarRentalFacade : ICarRentalFacade
    {
        private readonly IVehicleRepository _carRepository;

        public CarRentalFacade(IVehicleRepository vehicleRepository)
        {
            _carRepository = vehicleRepository;
        }

        private readonly IVehicleInspectionService _inspectionService;

        public CarRentalFacade(IVehicleInspectionService inspectionService)
        {
            _inspectionService = inspectionService;
        }

        public CarRentalFacade(IVehicleRepository vehicleRepository, IVehicleInspectionService vehicleInspectionService)
        {
            _carRepository = vehicleRepository;
            _inspectionService = vehicleInspectionService;
        }
        public void AddVehicleData(IVehicle data, string vehicleTypes)
        {
            AddVehicle.AddVehicleNew(_carRepository, data,vehicleTypes);
        }

        public void RemoveVehicle(int id, VehicleType.VehicleTypes types)
        {
            DeleteVehicle.DeleteData(_carRepository, id, types);
        }

        public void deleteRental(int id)
        {
            _carRepository.DeleteRentalRegistration(id);
        }

        public List<RentalProc> getRentalsCustomer(int id)
        {
            return _carRepository.GetRentalsByCustomer(id);
        }

        public object GetVehicleById(int id, string types)
        {
            return GetById.GetVehicle(_carRepository, id, types);
        }

        public List<VehicleList> getAllVehicles()
        {
            return GetVehicle.GetAllVehicle(_carRepository);
        }

        public bool UpdateVehicles(int id, Vehicle data, VehicleType.VehicleTypes vehicleTypes)
        {
           var res = UpdateVehicle.UpdateVehicleData(_carRepository, id, data, vehicleTypes);
           return res;
        }

        public void AddInspectionCar(CarInspection carInspection, bool type)
        {
            AddCarInspection.AddInspectionBasic(_carRepository, _inspectionService, carInspection, type);
        }

        public List<CarInspection> GetAllInspectionCars()
        {
            return GetCarInspection.GetInspection(_carRepository);
        }

        public HybridCar getHybridCars(int id)
        {
            return _carRepository.GetHybridCarById(id);
        }

        public ElectricCar getElectricCars(int id)
        {
            return _carRepository.GetElectricCarById(id);
        }

        public CombustionCar getCombustionCars(int id)
        {
            return _carRepository.GetCombustionCarById(id);
        }

        public ElectricMotorcycle getElectricMotorcycles(int id)
        {
            return _carRepository.GetElectricMotorcycleById(id);
        }

        public CombustionMotorcycle getCombustionMotorcycles(int id)
        {
            return _carRepository.GetCombustionMotorcycleById(id);
        }

        public List<Client> getAllClients()
        {
            return _carRepository.GetClients();
        }

        public Client getClient(string name)
        {
            return _carRepository.GetClient(name);
        }

        public bool UpdatePhoneNumber(int idClient, string phoneNumber)
        {
            var clients = _carRepository.GetClients();
            foreach (var client in clients)
            {
                if (client.PhoneNumber.Equals(phoneNumber))
                {
                    return false;
                }
            }

            _carRepository.UpdateClientPhone(idClient, phoneNumber);
            return true;
        }
    }
}
