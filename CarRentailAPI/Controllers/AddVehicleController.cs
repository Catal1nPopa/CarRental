using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddVehicleController : ControllerBase
    {
        private readonly IVehicleRepository _carRepository;

        public AddVehicleController(IVehicleRepository vehicleRepository)
        {
            _carRepository = vehicleRepository;
        }

        [HttpPost("AddCombustionCar")]
        public void AddCombustionCar(CombustionCar car)
        {
            AddVehicle.AddCombustionCar(_carRepository, car);
        }

        [HttpPost("AddElectricCar")]
        public void AddElectricCar(ElectricCar car)
        {
            AddVehicle.AddElectricCar(_carRepository, car);
        }

        [HttpPost("AddHybridCar")]
        public void AddHybridCar(HybridCar car)
        {
            AddVehicle.AddHybridCar(_carRepository, car);
        }

        [HttpPost("AddCombustionMotorcycle")]
        public void AddCombustionCar(CombustionMotorcycle car)
        {
            AddVehicle.AddCombustionMotorcycle(_carRepository, car);
        }

        [HttpPost("AddElectricMotorcycle")]
        public void AddElectricMotorcycle(ElectricMotorcycle car)
        {
            AddVehicle.AddElectricMotorcycle(_carRepository, car);
        }
    }
}
