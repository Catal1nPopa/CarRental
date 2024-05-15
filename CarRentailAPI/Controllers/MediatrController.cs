using CarRentail.Application.Mediator;
using CarRentail.Application.Models;
using CarRentail.Application.Requests;
using CarRentail.Application.Services;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
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
            try
            {
                var response = await CreateNewRental.Create(dataRental, _mediator);
                if (response)
                    return Ok();
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                SendEmail.SendEmailException(ex, _mediator);
                return BadRequest();
            }
        }

        [HttpGet("GetRentals")]
        public Task<List<RentalProc>> GetRentalProc()
        {
            try
            {
                var request = new GetRentailsRequest();
                var rentals = _mediator.Send(request);
                return rentals;
            }
            catch (Exception ex)
            {
                SendEmail.SendEmailException(ex, _mediator);
                return null;
            }
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
                    if (rent.VehicleId == dataUpdateVehicleStatus.Id && rent.VehicleType == dataUpdateVehicleStatus.VehicleType )
                    {
                        if (latestRental == null || rent.EndTime > latestRental.EndTime)
                        {
                            latestRental = rent;
                        }
                    }
                }

                var checkStatus = await GetVehicleData.getVehicle(dataUpdateVehicleStatus.Id,
                    dataUpdateVehicleStatus.VehicleType, _mediator);
                if (latestRental != null)
                {
                    if (latestRental.EndTime < DateTime.Now && !checkStatus.State)
                    {
                        UpdateVehicleStatusRequest dataUpdate = new UpdateVehicleStatusRequest();
                        dataUpdate.idCar = dataUpdateVehicleStatus.Id;
                        dataUpdate.vehicleTypes = dataUpdateVehicleStatus.VehicleType;
                        var response = await _mediator.Send(dataUpdate);
                    }
                }
            }
            catch (Exception ex)
            {
                SendEmail.SendEmailException(ex, _mediator);
                Console.WriteLine(ex.Message);
            };
        }
    }
}
