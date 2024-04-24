using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Entities
{
    public class RentalProc
    {
        public RentalProc() { }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }

        public RentalProc(int id, int customerId, string carNumber, DateTime starTime, DateTime endTime)
        {
            Id = id;
            CustomerId = customerId;
            CarNumber = carNumber;
            StarTime = starTime;
            EndTime = endTime;
        }
    }
}
