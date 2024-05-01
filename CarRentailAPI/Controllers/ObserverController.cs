using CarRentail.Application.Observer;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObserverController : ControllerBase
    {
        private readonly VehicleSubject _vehicleSubject;
        private readonly IVehicleObserver _vehicleObserver;

        public ObserverController(VehicleSubject vehicleSubject, IVehicleObserver vehicleObserver)
        {
            _vehicleSubject = vehicleSubject;
            _vehicleObserver = vehicleObserver;

            _vehicleSubject.Attach(_vehicleObserver);
        }

        [HttpPost("Observer")]
        public IActionResult AddVehicle()
        {
            _vehicleSubject.Notify();
            return Ok("Adaugare vehicol cu succes");
        }

    }
}
