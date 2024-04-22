using CarRentail.Application.Adapter;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Adapter : ControllerBase
    {
        private readonly ElectricCarToMotorcycleAdapter _electricCarToMotorcycleAdapter;

        public Adapter(ElectricCarToMotorcycleAdapter electricCarToMotorcycleAdapter)
        {
            _electricCarToMotorcycleAdapter = electricCarToMotorcycleAdapter;
        }

        [HttpGet("AdapterElectricCarToMotorcycle")]
        public IActionResult ConvertElectricCarToMotorcycle()
        {
            ElectricCar electricCar = new ElectricCar
            {
                Id = 1,
                Brand = "Harley-Davidson",
                Model = "LiveWire",
                Year = 2022,
                Distance = 5000,
                Photo = "harley_livewire.jpg",
                Price = 30000,
                EnginePower = 100,
                BatteryCapacity = 15,
                State = true
            };

            // Se utilizează adaptorul pentru a converti ElectricCar în ElectricMotorcycle
            IVehicle electricMotorcycle = _electricCarToMotorcycleAdapter.Adapt(electricCar);

            // Returnează obiectul ElectricMotorcycle într-un răspuns HTTP
            return Ok(electricMotorcycle);
        }
    }
}

