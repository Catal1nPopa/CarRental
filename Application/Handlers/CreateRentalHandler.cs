using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using MediatR;

namespace CarRentail.Application.Handlers
{
    public class CreateRentalHandler : IRequestHandler<RentCarRequest, RentalProc>
    {
        private readonly IVehicleRepository _carRepository;

        public CreateRentalHandler(IVehicleRepository vehicleRepository)
        {
            _carRepository = vehicleRepository;
        }
        public async Task<RentalProc> Handle(RentCarRequest request, CancellationToken cancellationToken)
        {
            var data = new RentalProc();
            data.CarNumber = request.CarNumber;
            data.VehicleId = request.VehicleId;
            data.VehicleType = request.VehicleType;
            data.CustomerId = request.CustomerId;
            data.StarTime = request.StarTime;
            data.EndTime = request.EndTime;
            data.TotalPrice = request.TotalPrice;

            _carRepository.UpdateClientRentals(request.CustomerId);

            _carRepository.AddRentalRegistration(data);
            return data;
        }
    }
}
