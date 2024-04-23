using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Decorator
{
    public abstract class VehicleInspectionDecorator : IVehicleInspectionService
    {
        protected IVehicleInspectionService _decoratedInspectionService;

        protected VehicleInspectionDecorator(IVehicleInspectionService decoratedInspectionService)
        {
            _decoratedInspectionService = decoratedInspectionService;
        }
        public virtual string Inspect()
        {
            return _decoratedInspectionService.Inspect();
        }
    }
}
