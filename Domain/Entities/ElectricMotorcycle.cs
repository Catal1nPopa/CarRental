using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Domain.Entities
{
    public class ElectricMotorcycle : IVehicle
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
        public int BatteryCapacity { get; set; }
        public bool State { get; set; }

        public ElectricMotorcycle(){}

        public ElectricMotorcycle(int id, string brand,string carNumber, string model, int year, int distance, string photo, int price, int enginePower, int batteryCapacity, bool state)
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
            BatteryCapacity = batteryCapacity;
            State = state;
        }
    }
}
