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
    public class GetRentalHandler : IRequestHandler<GetRentailsRequest, List<RentalProc>>
    {
        private readonly IVehicleRepository _carRepository;

        public GetRentalHandler(IVehicleRepository vehicleRepository)
        {
            _carRepository = vehicleRepository;
        }


        public Task<List<RentalProc>> Handle(GetRentailsRequest request, CancellationToken cancellationToken)
        {
            var rentals =  _carRepository.GetAllRentals();
            return Task.FromResult(rentals);
        }
    }
}
