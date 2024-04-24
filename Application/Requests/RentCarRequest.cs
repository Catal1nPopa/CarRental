using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using MediatR;

namespace CarRentail.Application.Requests
{
    public class RentCarRequest : IRequest<RentalProc>
    {
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }

        public RentCarRequest() { }
        public RentCarRequest(int customerId, string carNumber, DateTime starTime, DateTime endTime)
        {
            CustomerId = customerId;
            CarNumber = carNumber;
            StarTime = starTime;
            EndTime = endTime;
        }
    }
}
