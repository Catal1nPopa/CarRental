﻿using CarRentail.Application.DBRequests;
using CarRentail.Application.VehicleBuilder;
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

        [HttpGet("GetAllClients")]
        public List<Client> GetVehicles()
        {
            return _carRentalFacade.getAllClients();
        }

        [HttpGet("GetClient")]
        public Client GetClient(string name)
        {
            return _carRentalFacade.getClient(name);
        }

        [HttpPatch("UpdatePhone")]
        public IActionResult UpdatePhoneNumber([FromBody] UpdatePhone dataProfile)
        {
            try
            {
                 var res = _carRentalFacade.UpdatePhoneNumber(dataProfile.Id, dataProfile.PhoneNumber);
                 if(res)
                    return Ok();
                 return BadRequest(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetRentalsCustomer")]
        public List<RentalProc> GetRentalProc(int id)
                {
            try
            {
                return _carRentalFacade.getRentalsCustomer(id);
            }
            catch (Exception ez)
            {
                return null;
            }
        }

        [HttpDelete("DeleteRental")]
        public void DeleteRent(int id)
        {
            try
            {
                _carRentalFacade.deleteRental(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
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
                case ("1"):
                    vehicleTypes = (VehicleTypes)1;
                    break;
                case ("2"):
                    vehicleTypes = (VehicleTypes)2;
                    break;
                case ("3"):
                    vehicleTypes = (VehicleTypes)3;
                    break;
                case ("4"):
                    vehicleTypes = (VehicleTypes)4;
                    break;
            }
            _carRentalFacade.RemoveVehicle(id, vehicleTypes);
        }

        [HttpPost("GetById")]
        public object GetVehicleById([FromBody] UpdateVehicleStatus data)
        {
            switch (data.VehicleType)
            {
                case "0":
                    return _carRentalFacade.getHybridCars(data.Id);
                case "2":
                    return _carRentalFacade.getElectricCars(data.Id);
                case "1":
                    return _carRentalFacade.getCombustionCars(data.Id);
                case "3":
                    return _carRentalFacade.getElectricMotorcycles(data.Id);
                case "4":
                    return _carRentalFacade.getCombustionMotorcycles(data.Id);
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }


        [HttpPost("AddVehicle")]
        public void AddObject(AddNewVehicle data)
        {
            data.State = true;
            IVehicleBuilder builder;

            switch (data.VehicleType)
            {
                case "1":
                    builder = new CombustionCarBuilder();
                    break;
                case "2":
                    builder = new ElectricCarBuilder().SetElectricCapacity(data.BatteryCapacity); ;
                    break;
                case "0":
                    builder = new HybridCarBuilder().SetElectricPower(data.ElectricPower);
                    break;
                case "3":
                    builder = new ElectricMotorcycleBuilder().SetElectricCapacity(data.BatteryCapacity);
                    break;
                case "4":
                    builder = new CombustionMotorcycleBuilder();
                    break;
                default:
                    throw new ArgumentException("Unsupported vehicle type.");
            }

            IVehicle newData = builder
                .SetId(data.Id)
                .SetBrand(data.Brand)
                .SetCarNumber(data.CarNumber)
                .SetModel(data.Model)
                .SetYear(data.Year)
                .SetDistance(data.Distance)
                .SetPhoto(data.Photo)
                .SetPrice(data.Price)
                .SetEnginePower(data.EnginePower)
                .SetState(data.State)
                .SetVehicleType(data.VehicleType)
                .Build();

            _carRentalFacade.AddVehicleData(newData, data.VehicleType);
        }

    }
}
