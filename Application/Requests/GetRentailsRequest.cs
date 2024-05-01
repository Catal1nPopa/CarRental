using CarRentail.Domain.Entities;
using MediatR;

namespace CarRentail.Application.Requests
{
    public class GetRentailsRequest : IRequest<List<RentalProc>>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public string VehicleType { get; set; }
        public string CarNumber { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }

        public GetRentailsRequest() { }

        public GetRentailsRequest(int id, int customerId, int vehicleId, string vehicleType, string carNumber, DateTime starTime, DateTime endTime)
        {
            Id = id;
            CustomerId = customerId;
            VehicleId = vehicleId;
            VehicleType = vehicleType;
            CarNumber = carNumber;
            StarTime = starTime;
            EndTime = endTime;
        }
    }
}
