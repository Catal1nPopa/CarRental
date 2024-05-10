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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarRentail.Application.Handlers
{
    public class UpdateVehicleStatusHandler : IRequestHandler<UpdateVehicleStatusRequest, bool>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public UpdateVehicleStatusHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<bool> Handle(UpdateVehicleStatusRequest request, CancellationToken cancellationToken)
        {

            switch (request.vehicleTypes)
            {
                case "1":
                    var newData = new CombustionCar
                    {
                        Id = request.idCar
                    };
                    _vehicleRepository.UpdateCombustionCar(newData);

                    break;
                case "4":
                    var comMoto = new CombustionMotorcycle
                    {
                        Id = request.idCar
                    };
                    _vehicleRepository.UpdateCombustionMotorcycle(comMoto);
                    break;
                case "2":
                    var newData2 = new ElectricCar
                    {
                        Id = request.idCar
                    };
                    _vehicleRepository.UpdateElectricCar(newData2);
                    break;
                case "3":
                    var carElec = new ElectricMotorcycle
                    {
                        Id = request.idCar
                    };
                    _vehicleRepository.UpdateElectricMotorcycle(carElec);
                    break;
                case "0":
                    var hybrid = new HybridCar
                    {
                        Id = request.idCar
                    };
                    _vehicleRepository.UpdateHybridCar(hybrid);
                    break;
                default:
                    throw new ArgumentException("Unsupported vehicle type.");
            }
            return true;
        }
    }
}
