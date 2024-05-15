using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using CarRentail.Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Handlers
{
    public class GetByIdVehicleHandler : IRequestHandler<GetByIdVehicleRequest, Vehicle>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public GetByIdVehicleHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<Vehicle> Handle(GetByIdVehicleRequest request, CancellationToken cancellationToken)
        {
            switch (request.vehicleType)
            {
                case "0":
                    var data = _vehicleRepository.GetHybridCarById(request.Id);
                    Vehicle newData = new Vehicle();
                    newData.Id = data.Id;
                    newData.CarNumber = data.CarNumber;
                    newData.Model = data.Model;
                    newData.Brand = data.Brand;
                    newData.Year = data.Year;
                    newData.Photo = data.Photo;
                    newData.Price = data.Price;
                    newData.EnginePower = data.EnginePower;
                    newData.ElectricPower = data.ElectricPower;
                    newData.State = data.State;
                    return newData;
                case "1":
                    var dataCombustionCar = _vehicleRepository.GetCombustionCarById(request.Id);
                    Vehicle newDataCombustionCar = new Vehicle();
                    newDataCombustionCar.Id = dataCombustionCar.Id;
                    newDataCombustionCar.CarNumber = dataCombustionCar.CarNumber;
                    newDataCombustionCar.Model = dataCombustionCar.Model;
                    newDataCombustionCar.Brand = dataCombustionCar.Brand;
                    newDataCombustionCar.Year = dataCombustionCar.Year;
                    newDataCombustionCar.Photo = dataCombustionCar.Photo;
                    newDataCombustionCar.Price = dataCombustionCar.Price;
                    newDataCombustionCar.EnginePower = dataCombustionCar.EnginePower;
                    newDataCombustionCar.State = dataCombustionCar.State;
                    return newDataCombustionCar;
                case "2":
                    var dataElectricCar = _vehicleRepository.GetElectricCarById(request.Id);
                    Vehicle newDataElectricCar = new Vehicle();
                    newDataElectricCar.Id = dataElectricCar.Id;
                    newDataElectricCar.CarNumber = dataElectricCar.CarNumber;
                    newDataElectricCar.Model = dataElectricCar.Model;
                    newDataElectricCar.Brand = dataElectricCar.Brand;
                    newDataElectricCar.Year = dataElectricCar.Year;
                    newDataElectricCar.Photo = dataElectricCar.Photo;
                    newDataElectricCar.Price = dataElectricCar.Price;
                    newDataElectricCar.EnginePower = dataElectricCar.EnginePower;
                    newDataElectricCar.BatteryCapacity = dataElectricCar.BatteryCapacity;
                    newDataElectricCar.ElectricPower = dataElectricCar.BatteryCapacity;
                    newDataElectricCar.State = dataElectricCar.State;
                    return newDataElectricCar;
                case "3":
                    var dataElectricMotorcycle = _vehicleRepository.GetElectricMotorcycleById(request.Id);
                    Vehicle newDataElectricMotorcycle = new Vehicle();
                    newDataElectricMotorcycle.Id = dataElectricMotorcycle.Id;
                    newDataElectricMotorcycle.CarNumber = dataElectricMotorcycle.CarNumber;
                    newDataElectricMotorcycle.Model = dataElectricMotorcycle.Model;
                    newDataElectricMotorcycle.Brand = dataElectricMotorcycle.Brand;
                    newDataElectricMotorcycle.Year = dataElectricMotorcycle.Year;
                    newDataElectricMotorcycle.Photo = dataElectricMotorcycle.Photo;
                    newDataElectricMotorcycle.Price = dataElectricMotorcycle.Price;
                    newDataElectricMotorcycle.EnginePower = dataElectricMotorcycle.EnginePower;
                    newDataElectricMotorcycle.BatteryCapacity = dataElectricMotorcycle.BatteryCapacity;
                    newDataElectricMotorcycle.ElectricPower = dataElectricMotorcycle.BatteryCapacity;
                    newDataElectricMotorcycle.State = dataElectricMotorcycle.State;
                    return newDataElectricMotorcycle;
                case "4":
                    var dataCombustionMotorcycle = _vehicleRepository.GetCombustionMotorcycleById(request.Id);
                    Vehicle newDataCombustionMotorcycle = new Vehicle();
                    newDataCombustionMotorcycle.Id = dataCombustionMotorcycle.Id;
                    newDataCombustionMotorcycle.CarNumber = dataCombustionMotorcycle.CarNumber;
                    newDataCombustionMotorcycle.Model = dataCombustionMotorcycle.Model;
                    newDataCombustionMotorcycle.Brand = dataCombustionMotorcycle.Brand;
                    newDataCombustionMotorcycle.Year = dataCombustionMotorcycle.Year;
                    newDataCombustionMotorcycle.Photo = dataCombustionMotorcycle.Photo;
                    newDataCombustionMotorcycle.Price = dataCombustionMotorcycle.Price;
                    newDataCombustionMotorcycle.EnginePower = dataCombustionMotorcycle.EnginePower;
                    newDataCombustionMotorcycle.State = dataCombustionMotorcycle.State;
                    return newDataCombustionMotorcycle;
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }

    }
}
