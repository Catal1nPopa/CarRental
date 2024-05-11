using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Entities
{
    public class UpdateVehicleStatus
    {
        public int Id { get; set; }
        public string VehicleType { get; set; }

        public UpdateVehicleStatus(){}
        public UpdateVehicleStatus(int id, string vehicleType)
        {
            Id = id;
            VehicleType = vehicleType;
        }
    }
}
