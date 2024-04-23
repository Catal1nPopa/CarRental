using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Decorator
{
    public class VehicleInspectionManager
    {
        private IVehicleInspectionService _inspectionService;

        public VehicleInspectionManager(IVehicleInspectionService inspectionService)
        {
            _inspectionService = inspectionService;
        }

        public string PerformBasicInspection()
        {
            return _inspectionService.Inspect();
        }

        public string PerformAdvancedInspection()
        {
            // Decorarea serviciului cu verificări avansate
            _inspectionService = new AdvancedInspectionServiceDecorator(_inspectionService);
            return _inspectionService.Inspect();
        }
    }
}
