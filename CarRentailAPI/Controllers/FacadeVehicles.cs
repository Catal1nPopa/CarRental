using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static CarRentail.Domain.Enums.VehicleType;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacadeVehicles : ControllerBase
    {
        //private readonly ICarRentalFacade _carRentalFacade;

        //public FacadeVehicles(ICarRentalFacade carRentalFacade)
        //{
        //    _carRentalFacade = carRentalFacade;
        //}
        
        //[HttpGet("Facade Get All")]
        //public List<VehicleList> GetVehicle()
        //{
        //    return _carRentalFacade.getAllVehicles();
        //}

        //[HttpDelete("Facade Delete")]
        //public void DeleteVehicle(int id, VehicleType.VehicleTypes type)
        //{
        //     _carRentalFacade.RemoveVehicle(id, type);
        //}

        //[HttpPut("Fcade Update")]
        //public bool UpdateDateVehicle(int id, Vehicle data, VehicleType.VehicleTypes vehicleTypes)
        //{
        //   var res = _carRentalFacade.UpdateVehicles(id, data, vehicleTypes);
        //   return res;
        //}

        //[HttpPost("Facade GetById")]
        //public object GetVehicleById(int id, VehicleType.VehicleTypes vehicleType)
        //{
        //    var dataVehicle = _carRentalFacade.GetVehicleById(id, vehicleType);
        //    if (dataVehicle != null)
        //    {
        //        return dataVehicle;
        //    }
        //    else
        //    {
        //        return "Datele nu au fost gasite";
        //    }
        //}

        //[HttpPost("Facade Add Object")]
        //public void AddObject(Vehicle data, VehicleType.VehicleTypes vehicleTypes)
        //{
        //    IVehicle newData;

        //    switch (vehicleTypes)
        //    {
        //        case VehicleType.VehicleTypes.CombustionCar:
        //            newData = new CombustionCar
        //            {
        //                Id = data.Id,
        //                Brand = data.Brand,
        //                CarNumber = data.CarNumber,
        //                Model = data.Model,
        //                Year = data.Year,
        //                Distance = data.Distance,
        //                Photo = data.Photo,
        //                Price = data.Price,
        //                EnginePower = data.EnginePower,
        //                State = data.State
        //            };
        //            break;
        //        case VehicleType.VehicleTypes.ElectricCar:
        //            newData = new ElectricCar
        //            {
        //                Id = data.Id,
        //                Brand = data.Brand,
        //                CarNumber = data.CarNumber,
        //                Model = data.Model,
        //                Year = data.Year,
        //                Distance = data.Distance,
        //                Photo = data.Photo,
        //                Price = data.Price,
        //                EnginePower = data.EnginePower,
        //                BatteryCapacity = data.BatteryCapacity,
        //                State = data.State
        //            };
        //            break;
        //        case VehicleTypes.HybridCar:
        //            string nul;
        //            newData = new HybridCar
        //            {
        //                Id = data.Id,
        //                Brand = data.Brand,
        //                CarNumber = data.CarNumber,
        //                Model = data.Model,
        //                Year = data.Year,
        //                Distance = data.Distance,
        //                Photo = data.Photo,
        //                Price = data.Price,
        //                EnginePower = data.EnginePower,
        //                ElectricPower = data.ElectricPower,
        //                State = data.State
        //            };
        //            break;
        //        case VehicleTypes.ElectricMotorcycle:
        //            newData = new ElectricMotorcycle
        //            {
        //                Id = data.Id,
        //                Brand = data.Brand,
        //                CarNumber = data.CarNumber,
        //                Model = data.Model,
        //                Year = data.Year,
        //                Distance = data.Distance,
        //                Photo = data.Photo,
        //                Price = data.Price,
        //                EnginePower = data.EnginePower,
        //                BatteryCapacity = data.BatteryCapacity,
        //                State = data.State
        //            };
        //            break;
        //        case VehicleTypes.CombustionMotorcycle:
        //            newData = new CombustionMotorcycle
        //            {
        //                Id = data.Id,
        //                Brand = data.Brand,
        //                CarNumber = data.CarNumber,
        //                Model = data.Model,
        //                Year = data.Year,
        //                Distance = data.Distance,
        //                Photo = data.Photo,
        //                Price = data.Price,
        //                EnginePower = data.EnginePower,
        //                State = data.State
        //            };
        //            break;
        //        default:
        //            throw new ArgumentException("Unsupported vehicle type.");
        //    }

        //    _carRentalFacade.AddVehicleData(newData, vehicleTypes);
        //}
    }
}
