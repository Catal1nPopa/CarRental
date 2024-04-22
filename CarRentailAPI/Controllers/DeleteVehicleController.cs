using CarRentail.Application.DBRequests;
using CarRentail.Domain.Enums;
using CarRentail.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteVehicleController : ControllerBase
    {
        private readonly IVehicleRepository _carRepository;

        public DeleteVehicleController(IVehicleRepository vehicleRepository)
        {
            _carRepository = vehicleRepository;
        }

        [HttpDelete("DeleteVehicle")]
        public void DeleteVehicles(int id, VehicleType.VehicleTypes types)
        {
            var res = DeleteVehicle.DeleteData(_carRepository, id, types);
            //return res;
        }
    }
}
