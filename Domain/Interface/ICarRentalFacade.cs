using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Domain.Enums;

namespace CarRentail.Domain.Interface
{
    public interface ICarRentalFacade
    {
        void AddVehicleData(IVehicle data, VehicleType.VehicleTypes vehicleTypes);
        void RemoveVehicle(int id, VehicleType.VehicleTypes types);
        object GetVehicleById(int id, VehicleType.VehicleTypes types);
        List<VehicleList> getAllVehicles();
        bool UpdateVehicles(int id, Vehicle data, VehicleType.VehicleTypes vehicleTypes);
    }
}
