using CarRentail.Domain.Interface;

namespace CarRentail.Domain.Entities
{
    public class CombustionMotorcycle : IVehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string CarNumber { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Distance { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public int EnginePower { get; set; }
        public bool State { get; set; }
        
        public CombustionMotorcycle(){}

        public CombustionMotorcycle(int id, string brand, string carNumber ,string model, int year, int distance, string photo, int price, int enginePower, bool state)
        {
            Id = id;
            Brand = brand;
            CarNumber = carNumber;
            Model = model;
            Year = year;
            Distance = distance;
            Photo = photo;
            Price = price;
            EnginePower = enginePower;
            State = state;
        }
    }
}
