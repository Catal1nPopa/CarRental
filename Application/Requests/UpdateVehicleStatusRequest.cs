using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Requests
{
    public class UpdateVehicleStatusRequest : IRequest<bool>
    {
        public int idCar {  get; set; }
        public string vehicleTypes { get; set; }
        public string Brand { get; set; }
        public string CarNumber { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Distance { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public int EnginePower { get; set; }
        public int ElectricPower { get; set; }
        public int BatteryCapacity { get; set; }
        public UpdateVehicleStatusRequest() { }

        public UpdateVehicleStatusRequest(int idCar, string vehicleTypes, string brand, string carNumber, string model, int year, int distance, string photo, int price, int enginePower, int electricPower, int batteryCapacity)
        {
            this.idCar = idCar;
            this.vehicleTypes = vehicleTypes;
            Brand = brand;
            CarNumber = carNumber;
            Model = model;
            Year = year;
            Distance = distance;
            Photo = photo;
            Price = price;
            EnginePower = enginePower;
            ElectricPower = electricPower;
            BatteryCapacity = batteryCapacity;
        }
    }
}
