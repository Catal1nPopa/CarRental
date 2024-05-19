using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using CarRentailAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleInspectionController : ControllerBase
    {
        private readonly ICarRentalFacade _carRentalFacade;

        public VehicleInspectionController(ICarRentalFacade carRentalFacade)
        {
            _carRentalFacade = carRentalFacade;
        }

        [HttpPost("CreateInspection")]
        public void AddInspection([FromBody] CreateInspection createInspection)
        {
            CarInspection carInspection = new CarInspection();
            carInspection.CarNumber = createInspection.carNumber;
            carInspection.Date = createInspection.dateTime;
            _carRentalFacade.AddInspectionCar(carInspection, createInspection.advanceInspection);
        }

        [HttpGet("GetInspections")]
        public List<CarInspection> GetInspection()
        {
            return _carRentalFacade.GetAllInspectionCars();
        }
    }
}
