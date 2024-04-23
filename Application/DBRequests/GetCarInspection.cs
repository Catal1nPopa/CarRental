using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.DBRequests
{
    public class GetCarInspection
    {
        public static List<CarInspection> GetInspection(IVehicleRepository vehicleRepository)
        {
            return vehicleRepository.GetAllInspections();
        }
    }
}
