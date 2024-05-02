using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
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

        [HttpPost("CreateCarInspection - Decorator")]
        public void AddInspection(string carNumber, DateTime dateTime, CarInspectionEnum type)
        {
            CarInspection carInspection = new CarInspection();
            carInspection.CarNumber = carNumber;
            carInspection.Date = dateTime;
            _carRentalFacade.AddInspectionCar(carInspection, type);
        }

        [HttpGet("GetInspections")]
        public List<CarInspection> GetInspection()
        {
            return _carRentalFacade.GetAllInspectionCars();
        }
    }
}
