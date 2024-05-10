using CarRentail.Domain.Entities;
using MediatR;

namespace CarRentail.Application.Requests
{
    public class RentCarRequest : IRequest<RentalProc>
    {
        public int CustomerId { get; set; }
        public string CarNumber { get; set; }
        public int VehicleId { get; set; }
        public string VehicleType { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalPrice { get; set; }
        public RentCarRequest() { }

        public RentCarRequest(int customerId, string carNumber, int vehicleId, string vehicleType, DateTime starTime, DateTime endTime, int totalPrice)
        {
            CustomerId = customerId;
            CarNumber = carNumber;
            VehicleId = vehicleId;
            VehicleType = vehicleType;
            StarTime = starTime;
            EndTime = endTime;
            TotalPrice = totalPrice;
        }
    }
}
