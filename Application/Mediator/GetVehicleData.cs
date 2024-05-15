using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Application.Models;
using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
using MediatR;

namespace CarRentail.Application.Mediator
{
    public class GetVehicleData
    {
        public static async Task<Vehicle> getVehicle(int Id, string type, IMediator _mediator)
        {
            GetByIdVehicleRequest checkVehicle = new GetByIdVehicleRequest();
            checkVehicle.Id = Id;
            checkVehicle.vehicleType = type;
            return await _mediator.Send(checkVehicle);
        }
    }
}
