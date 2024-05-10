using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using CarRentail.Application.DBRequests;
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

        public object GetVehicleById(int id, VehicleType.VehicleTypes types)
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

        public void AddInspectionCar(CarInspection carInspection, CarInspectionEnum type)
        {
            AddCarInspection.AddInspectionBasic(_carRepository, _inspectionService, carInspection, type);
        }

        public List<CarInspection> GetAllInspectionCars()
        {
            return GetCarInspection.GetInspection(_carRepository);
        }
    }
}
