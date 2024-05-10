using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Domain.Entities
{
    public class CombustionCar : IVehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string CarNumber { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Distance { get; set; }
        public string Photo { get; set; }
        public bool State { get; set; }
        public int Price { get; set; }
        public int EnginePower { get; set; }
        public string VehicleType { get; set; } 
        
        public CombustionCar(){}

        public CombustionCar(int id, string brand, string carModel,string model, int year, int distance, string photo, bool state, int price, int enginePower, string vehicleType)
        {
            Id = id;
            Brand = brand;
            CarNumber = carModel;
            Model = model;
            Year = year;
            Distance = distance;
            Photo = photo;
            State = state;
            Price = price;
            EnginePower = enginePower;
            VehicleType = vehicleType;
        }
    }
}
