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
                //case "1":
                //    return await Task.FromResult<object>(_vehicleRepository.GetCombustionCarById(request.Id));
                //case "2":
                //    return await Task.FromResult<object>(_vehicleRepository.GetElectricCarById(request.Id));
                //case "3":
                //    return await Task.FromResult<object>(_vehicleRepository.GetElectricMotorcycleById(request.Id));
                //case "4":
                //    return await Task.FromResult<object>(_vehicleRepository.GetCombustionMotorcycleById(request.Id));
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }

    }
}
