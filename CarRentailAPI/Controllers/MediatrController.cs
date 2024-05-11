using CarRentail.Application.Models;
using CarRentail.Application.Requests;
using CarRentail.Application.Services;
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
        public async Task<IActionResult> CreateRental([FromBody] RentModel dataRental) 
        {
            if (dataRental.rentalDays > 0)
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
                    dataRent.TotalPrice = await _mediator.Send(new GetStrategyPriceRequest(dataRental.rentalDays));

                    var res = _mediator.Send(dataRent);

                    UpdateVehicleStatusRequest dataUpdate = new UpdateVehicleStatusRequest();
                    dataUpdate.idCar = dataRental.idCar;
                    dataUpdate.vehicleTypes = dataRental.vehicleTypes;

                    var response = _mediator.Send(dataUpdate);
                    return Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
              return BadRequest();
            return BadRequest();
        }

        [HttpGet("GetRentals")]
        public Task<List<RentalProc>> GetRentalProc()
        {
            var request = new GetRentailsRequest();
            var rentals =  _mediator.Send(request);
            return rentals;
        }

        [HttpPatch("UpdateStatus")]
        public async Task UpdateStatusVehicle([FromBody] UpdateVehicleStatus dataUpdateVehicleStatus)
        {
            try
            {
                var request = new GetRentailsRequest();
                var rentals = await _mediator.Send(request);
                RentalProc latestRental = null;

                foreach (var rent in rentals)
                {
                    if (rent.VehicleId == dataUpdateVehicleStatus.Id && rent.VehicleType == dataUpdateVehicleStatus.VehicleType && rent.EndTime < DateTime.Now)
                    {
                        if (latestRental == null || rent.StarTime > latestRental.StarTime)
                        {
                            latestRental = rent;
                        }
                    }
                }
                if (latestRental != null)
                {
                    UpdateVehicleStatusRequest dataUpdate = new UpdateVehicleStatusRequest();
                    dataUpdate.idCar = dataUpdateVehicleStatus.Id;
                    dataUpdate.vehicleTypes = dataUpdateVehicleStatus.VehicleType;
                    var response = await _mediator.Send(dataUpdate);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            };
        }
    }
}
