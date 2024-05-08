using CarRentail.Application.Strategy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrategyController : ControllerBase
    {
        private readonly RentalService _rentalService;

        public StrategyController(RentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [Authorize]
        [HttpGet("Strategy")]
        public IActionResult CalculatePrice(int days)
        {
            decimal price = _rentalService.CalculateRentalPrice(days);
            return Ok(price);
        }

    }
}
