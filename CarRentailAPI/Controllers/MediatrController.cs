using CarRentail.Application.Models;
using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatrController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MediatrController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateRentalMediatr")]
        public async Task CreateRental([FromBody] RentModel dataRental) 
        {
            try
            {
                GetByIdVehicleRequest checkVehicle = new GetByIdVehicleRequest();
                checkVehicle.Id = dataRental.idCar;
                checkVehicle.vehicleType = dataRental.vehicleTypes;
                Vehicle checkResponse = await _mediator.Send(checkVehicle);

                RentCarRequest dataRent = new RentCarRequest();
                    dataRent.CustomerId = dataRental.CustomerId;
                    dataRent.CarNumber = checkResponse.CarNumber;
                    dataRent.VehicleId = dataRental.idCar;
                    dataRent.VehicleType = dataRental.vehicleTypes;
                    dataRent.StarTime = DateTime.Today;
                    dataRent.EndTime = DateTime.Today.AddDays(dataRental.rentalDays);

                    var res = _mediator.Send(dataRent);

                    UpdateVehicleStatusRequest dataUpdate = new UpdateVehicleStatusRequest();
                    dataUpdate.idCar = dataRental.idCar;
                    dataUpdate.vehicleTypes = dataRental.vehicleTypes;

                    var response = _mediator.Send(dataUpdate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet("GetRentals")]
        public Task<List<RentalProc>> GetRentalProc()
        {
            var request = new GetRentailsRequest();

            // Send the request to the mediator
            var rentals =  _mediator.Send(request);
            return rentals;
        }

    
    }
}
