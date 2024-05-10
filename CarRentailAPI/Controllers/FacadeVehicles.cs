using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static CarRentail.Domain.Enums.VehicleType;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacadeVehicles : ControllerBase
    {
        private readonly ICarRentalFacade _carRentalFacade;

        public FacadeVehicles(ICarRentalFacade carRentalFacade)
        {
            _carRentalFacade = carRentalFacade;
        }
        //[Authorize]
        [HttpGet("GetAllVehicles")]
        public List<VehicleList> GetVehicle()
        {
            return _carRentalFacade.getAllVehicles();
        }

        [HttpDelete("DeleteVehicle")]
        public void DeleteVehicle(int id, string type)
        {
            VehicleType.VehicleTypes vehicleTypes = new VehicleTypes();
            switch (type)
            {
                case ("0"):
                    vehicleTypes = 0;
                    break;
            }
            _carRentalFacade.RemoveVehicle(id, vehicleTypes);
        }

        //[HttpPut("Fcade Update")]
        //public bool UpdateDateVehicle(int id, Vehicle data, VehicleType.VehicleTypes vehicleTypes)
        //{
        //    var res = _carRentalFacade.UpdateVehicles(id, data, vehicleTypes);
        //    return res;
        //}

        [HttpPost("Facade GetById")]
        public object GetVehicleById(int id, VehicleType.VehicleTypes vehicleType)
        {
            var dataVehicle = _carRentalFacade.GetVehicleById(id, vehicleType);
            if (dataVehicle != null)
            {
                return dataVehicle;
            }
            else
            {
                return "Datele nu au fost gasite";
            }
        }

        [HttpPost("AddVehicle")]
        public void AddObject(AddNewVehicle data)
        {
            data.State = true;
            IVehicle newData;

            switch (data.VehicleType)
            {
                case "1":
                    newData = new CombustionCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        State = data.State,
                        VehicleType = "1"
                    };
                    break;
                case "2":
                    newData = new ElectricCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        BatteryCapacity = data.BatteryCapacity,
                        State = data.State,
                        VehicleType = "2"
                    };
                    break;
                case "0":
                    string nul;
                    newData = new HybridCar
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,   
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        ElectricPower = data.ElectricPower,
                        State = data.State,
                        VehicleType = "0"
                    };
                    break;
                case "3":
                    newData = new ElectricMotorcycle
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        BatteryCapacity = data.BatteryCapacity,
                        State = data.State,
                        VehicleType = "3"
                    };
                    break;
                case "4":
                    newData = new CombustionMotorcycle
                    {
                        Id = data.Id,
                        Brand = data.Brand,
                        CarNumber = data.CarNumber,
                        Model = data.Model,
                        Year = data.Year,
                        Distance = data.Distance,
                        Photo = data.Photo,
                        Price = data.Price,
                        EnginePower = data.EnginePower,
                        State = data.State,
                        VehicleType = "4"
                    };
                    break;
                default:
                    throw new ArgumentException("Unsupported vehicle type.");
            }

            _carRentalFacade.AddVehicleData(newData, data.VehicleType);
        }
    }
}
