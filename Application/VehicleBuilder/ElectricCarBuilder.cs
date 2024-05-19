using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.VehicleBuilder
{
    public class ElectricCarBuilder : IVehicleBuilder
    {
        private ElectricCar _car = new ElectricCar();

        public IVehicleBuilder SetId(int id) { _car.Id = id; return this; }
        public IVehicleBuilder SetBrand(string brand) { _car.Brand = brand; return this; }
        public IVehicleBuilder SetCarNumber(string carNumber) { _car.CarNumber = carNumber; return this; }
        public IVehicleBuilder SetModel(string model) { _car.Model = model; return this; }
        public IVehicleBuilder SetYear(int year) { _car.Year = year; return this; }
        public IVehicleBuilder SetDistance(int distance) { _car.Distance = distance; return this; }
        public IVehicleBuilder SetPhoto(string photo) { _car.Photo = photo; return this; }
        public IVehicleBuilder SetPrice(int price) { _car.Price = price; return this; }
        public IVehicleBuilder SetEnginePower(int enginePower) { _car.EnginePower = enginePower; return this; }
        public IVehicleBuilder SetBatteryCapacity(int batteryCapacity) { _car.BatteryCapacity = batteryCapacity; return this; }
        public IVehicleBuilder SetState(bool state) { _car.State = state; return this; }
        public IVehicleBuilder SetVehicleType(string vehicleType) { _car.VehicleType = vehicleType; return this; }
        public IVehicleBuilder SetElectricPower(int electricPower)
        {
            throw new NotImplementedException();
        }

        public IVehicle Build() { return _car; }
        public IVehicleBuilder SetElectricCapacity(int electricCapacity)
        {
            _car.BatteryCapacity = electricCapacity;
            return this;
        }
    }

}
