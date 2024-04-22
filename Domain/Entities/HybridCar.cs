using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Domain.Entities
{
    public class HybridCar : IVehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Distance { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public int EnginePower { get; set; }
        public int ElectricPower { get; set; }
        public bool State { get; set; }

        public HybridCar(){}

        public HybridCar(int id, string brand, string model, int year, int distance, string photo, int price, int enginePower, int electricPower, bool state)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Distance = distance;
            Photo = photo;
            Price = price;
            EnginePower = enginePower;
            ElectricPower = electricPower;
            State = state;
        }
    }
}
