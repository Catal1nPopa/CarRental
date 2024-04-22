using CarRentail.Application.DBRequests;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetVehiclesController : ControllerBase
    {
        private readonly IVehicleRepository _electricCarRepository;

        public GetVehiclesController(IVehicleRepository vehicleRepository)
        {
            _electricCarRepository = vehicleRepository;
        }


        //[HttpGet("GetAllVehicles")]
        //public List<VehicleList> GetAllVehicles()
        //{
        //    return (GetVehicle.GetAllVehicle(_electricCarRepository));
        //}
    }
}
