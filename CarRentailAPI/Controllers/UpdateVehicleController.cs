using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using CarRentail.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateVehicleController : ControllerBase
    {
        private readonly IVehicleRepository _CarRepository;

        public UpdateVehicleController(IVehicleRepository vehicleRepository)
        {
            _CarRepository = vehicleRepository;
        }


        [HttpPut("UpdateCombustionCar")]
        public string UpdateCombustionCar(int id, CombustionCar combustionCar)
        {
            var res = UpdateVehicle.UpdateCombustionCar(_CarRepository, id, combustionCar);
            if (res)
                return "Actualizare cu succes!";
            else
                return "Eroare la actualizare!";
        }

        [HttpPut("UpdateElectricCar")]
        public string UpdateElectricCar(int id, ElectricCar electricCar)
        {
            var res = UpdateVehicle.UpdateElectricCar(_CarRepository, id, electricCar);
            if (res)
                return "Actualizare cu succes!";
            else
                return "Eroare la actualizare!";
        }

        [HttpPut("UpdateHybridCar")]
        public string UpdateHybridCar(int id, HybridCar hybridCar)
        {
            var res = UpdateVehicle.UpdateHybridCar(_CarRepository, id, hybridCar);
            if (res)
                return "Actualizare cu succes!";
            else
                return "Eroare la actualizare!";
        }

        [HttpPut("UpdateElectricMotorcycle")]
        public string UpdateElectricMotorcycle(int id, ElectricMotorcycle electricMotorcycle)
        {
            var res = UpdateVehicle.UpdateeElectricMotor(_CarRepository, id, electricMotorcycle);
            if (res)
                return "Actualizare cu succes!";
            else
                return "Eroare la actualizare!";
        }

        [HttpPut("UpdateCombustionMotorcycle")]
        public string UpdateCombustionMotorcycle(int id, CombustionMotorcycle combustionMotorcycle)
        {
            var res = UpdateVehicle.UpdateCombustionMotorcycle(_CarRepository, id, combustionMotorcycle);
            if (res)
                return "Actualizare cu succes!";
            else
                return "Eroare la actualizare!";
        }
    }
}
