using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Enums;

namespace CarRentail.Domain.Entities
{
    public class RentalProc
    {
        public RentalProc() { }

        public int Id { get; set; }
        public int CustomerId { get; set; }

        public int VehicleId { get; set; }
        public string VehicleType { get; set;}
        public string CarNumber { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalPrice { get; set; }

        public RentalProc(int id, int customerId, int vehicleId, string vehicleType, string carNumber, DateTime starTime, DateTime endTime, int totalPrice)
        {
            Id = id;
            CustomerId = customerId;
            VehicleId = vehicleId;
            VehicleType = vehicleType;
            CarNumber = carNumber;
            StarTime = starTime;
            EndTime = endTime;
            TotalPrice = totalPrice;
        }
    }
}
