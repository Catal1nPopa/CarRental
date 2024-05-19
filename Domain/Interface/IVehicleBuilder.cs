using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Interface
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder SetId(int id);
        IVehicleBuilder SetBrand(string brand);
        IVehicleBuilder SetCarNumber(string carNumber);
        IVehicleBuilder SetModel(string model);
        IVehicleBuilder SetYear(int year);
        IVehicleBuilder SetDistance(int distance);
        IVehicleBuilder SetPhoto(string photo);
        IVehicleBuilder SetPrice(int price);
        IVehicleBuilder SetEnginePower(int enginePower);
        IVehicleBuilder SetState(bool state);
        IVehicleBuilder SetVehicleType(string vehicleType);
        IVehicleBuilder SetElectricCapacity(int electricCapacity);
        IVehicleBuilder SetElectricPower(int electricPower);
        IVehicle Build();
    }

}
