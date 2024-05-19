using CarRentail.Domain.Enums;

namespace CarRentailAPI.Models
{
    public class CreateInspection
    {
        public string carNumber { get; set; }
        public DateTime dateTime { get; set; }
        public bool advanceInspection{ get; set; }

        public CreateInspection(){}

        public CreateInspection(string carNumber, DateTime dateTime, bool advanceInspection)
        {
            this.carNumber = carNumber;
            this.dateTime = dateTime;
            this.advanceInspection = advanceInspection;
        }
    }
}
