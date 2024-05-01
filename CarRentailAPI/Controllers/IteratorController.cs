using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IteratorController : ControllerBase
    {
        [HttpGet(" Get All")]
        public VehicleList GetVehicle()
        {
            

            var hybridCars = new List<HybridCar> { new HybridCar
                {
                    Id = 1,
                    Brand = "Toyota",
                    CarNumber = "ABC123",
                    Model = "Prius",
                    Year = 2019,
                    Distance = 30000,
                    Photo = "prius.jpg",
                    Price = 25000,
                    EnginePower = 100,
                    ElectricPower = 50,
                    State = true
                },
                new HybridCar
                {
                    Id = 2,
                    Brand = "Honda",
                    CarNumber = "DEF456",
                    Model = "Insight",
                    Year = 2020,
                    Distance = 20000,
                    Photo = "insight.jpg",
                    Price = 28000,
                    EnginePower = 110,
                    ElectricPower = 60,
                    State = true
                } };
            var electricCars = new List<ElectricCar> { new ElectricCar
                {
                    Id = 1,
                    Brand = "Tesla",
                    CarNumber = "TES001",
                    Model = "Model S",
                    Year = 2021,
                    Distance = 10000,
                    Photo = "model_s.jpg",
                    Price = 80000,
                    EnginePower = 500,
                    BatteryCapacity = 100,
                    State = true
                },
                new ElectricCar
                {
                    Id = 2,
                    Brand = "Nissan",
                    CarNumber = "LEAF001",
                    Model = "Leaf",
                    Year = 2020,
                    Distance = 15000,
                    Photo = "leaf.jpg",
                    Price = 35000,
                    EnginePower = 150,
                    BatteryCapacity = 50,
                    State = true
                } };
            var combustionCars = new List<CombustionCar> { new CombustionCar
                                                              {
                                                                  Id = 1,
                                                                  Brand = "Toyota",
                                                                  CarNumber = "ABC123",
                                                                  Model = "Corolla",
                                                                  Year = 2018,
                                                                  Distance = 50000,
                                                                  Photo = "corolla.jpg",
                                                                  State = true,
                                                                  Price = 15000,
                                                                  EnginePower = 120
                                                              },
                                                              new CombustionCar
                                                              {
                                                                  Id = 2,
                                                                  Brand = "Honda",
                                                                  CarNumber = "XYZ789",
                                                                  Model = "Civic",
                                                                  Year = 2017,
                                                                  Distance = 60000,
                                                                  Photo = "civic.jpg",
                                                                  State = true,
                                                                  Price = 17000,
                                                                  EnginePower = 130
                                                              } };
            var electricMotorcycles = new List<ElectricMotorcycle> { new ElectricMotorcycle
                {
                    Id = 1,
                    Brand = "Zero Motorcycles",
                    CarNumber = "ZERO001",
                    Model = "SR/F",
                    Year = 2021,
                    Distance = 5000,
                    Photo = "sr_f.jpg",
                    Price = 18000,
                    EnginePower = 110,
                    BatteryCapacity = 14,
                    State = true
                },
                new ElectricMotorcycle
                {
                    Id = 2,
                    Brand = "Energica",
                    CarNumber = "ENERG001",
                    Model = "Eva Ribelle",
                    Year = 2020,
                    Distance = 8000,
                    Photo = "eva_ribelle.jpg",
                    Price = 20000,
                    EnginePower = 120,
                    BatteryCapacity = 21,
                    State = true
                }};
            var combustionMotorcycles = new List<CombustionMotorcycle> { new CombustionMotorcycle
                {
                    Id = 1,
                    Brand = "Harley-Davidson",
                    CarNumber = "HD001",
                    Model = "Sportster Iron 883",
                    Year = 2019,
                    Distance = 15000,
                    Photo = "sportster_iron_883.jpg",
                    Price = 12000,
                    EnginePower = 50,
                    State = true
                },
                new CombustionMotorcycle
                {
                    Id = 2,
                    Brand = "Yamaha",
                    CarNumber = "YZF001",
                    Model = "YZF-R6",
                    Year = 2020,
                    Distance = 10000,
                    Photo = "yzf_r6.jpg",
                    Price = 14000,
                    EnginePower = 120,
                    State = true
                }};

            // Create an instance of VehicleList
            var vehicleList = new VehicleList(hybridCars, electricCars, combustionCars, electricMotorcycles, combustionMotorcycles);

            return vehicleList;
        }

    }
}
