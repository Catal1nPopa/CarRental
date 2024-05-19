using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Entities;
using CarRentail.Application.Decorator;
using CarRentail.Domain.Enums;

namespace CarRentail.Application.DBRequests
{
    public class AddCarInspection
    {
        public static void AddInspectionBasic(IVehicleRepository vehicleRepository, IVehicleInspectionService caInspectionService, CarInspection carInspection, bool type)
        {
            switch (type)
            {
                case false:
                    var serviceManager = new VehicleInspectionManager(caInspectionService);
                    var result = serviceManager.PerformBasicInspection();
                    carInspection.Description = result;
                    carInspection.Advanced = false;
                    vehicleRepository.AddCarInspection(carInspection);
                    break;
                case true:
                    var serviceManagerAdvanced = new VehicleInspectionManager(caInspectionService);
                    var resultAdvanced = serviceManagerAdvanced.PerformAdvancedInspection();
                    carInspection.Description = resultAdvanced;
                    carInspection.Advanced = true;
                    vehicleRepository.AddCarInspection(carInspection);
                    break;
            }
            
        }
    }
}
