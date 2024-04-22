using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetVehicleByIdController : ControllerBase
    {
        private readonly IVehicleRepository _electricCarRepository;

        public GetVehicleByIdController(IVehicleRepository vehicleRepository)
        {
            _electricCarRepository = vehicleRepository;
        }

        //[HttpGet("GetVehicleById")]
        //public object GetVehicleById(int id, VehicleType.VehicleTypes typeVehicle)
        //{

        //    var dataVehicle = GetById.GetVehicle(_electricCarRepository, id, typeVehicle);
        //    if (dataVehicle == null)
        //    {
        //        return "Datele nu au fost gasite";
        //    }

        //    return dataVehicle;
        //}

        
    }
}
