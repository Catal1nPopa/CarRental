using CarRentail.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentail.Domain.Enums.VehicleType;

namespace CarRentail.Application.Requests
{
    public class GetByIdVehicleRequest : IRequest<Vehicle>
    {
        public int Id { get; set; }
        public string vehicleType { get; set; }
        public Vehicle vehicleData { get; set; }
        public GetByIdVehicleRequest() { }

        public GetByIdVehicleRequest(int id, string VehicleType)
        {
            Id = id;
            vehicleType = VehicleType;
        }
    }
}
