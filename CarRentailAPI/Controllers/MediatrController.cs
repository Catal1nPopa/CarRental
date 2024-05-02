using CarRentail.Application.Requests;
using CarRentail.Domain.Entities;
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
        public void CreateRental([FromBody] RentCarRequest request) 
        {
            var data = _mediator.Send(request);
            //request Ok(data);
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
