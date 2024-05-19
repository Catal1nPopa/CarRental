using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.VehicleBuilder
{
    public class CombustionMotorcycleBuilder : IVehicleBuilder
    {
        private CombustionMotorcycle _motorcycle = new CombustionMotorcycle();

        public IVehicleBuilder SetId(int id) { _motorcycle.Id = id; return this; }
        public IVehicleBuilder SetBrand(string brand) { _motorcycle.Brand = brand; return this; }
        public IVehicleBuilder SetCarNumber(string carNumber) { _motorcycle.CarNumber = carNumber; return this; }
        public IVehicleBuilder SetModel(string model) { _motorcycle.Model = model; return this; }
        public IVehicleBuilder SetYear(int year) { _motorcycle.Year = year; return this; }
        public IVehicleBuilder SetDistance(int distance) { _motorcycle.Distance = distance; return this; }
        public IVehicleBuilder SetPhoto(string photo) { _motorcycle.Photo = photo; return this; }
        public IVehicleBuilder SetPrice(int price) { _motorcycle.Price = price; return this; }
        public IVehicleBuilder SetEnginePower(int enginePower) { _motorcycle.EnginePower = enginePower; return this; }
        public IVehicleBuilder SetState(bool state) { _motorcycle.State = state; return this; }
        public IVehicleBuilder SetVehicleType(string vehicleType) { _motorcycle.VehicleType = vehicleType; return this; }
        public IVehicleBuilder SetElectricCapacity(int electricCapacity)
        {
            throw new NotImplementedException();
        }

        public IVehicleBuilder SetElectricPower(int electricPower)
        {
            throw new NotImplementedException();
        }

        public IVehicle Build() { return _motorcycle; }
    }

}
