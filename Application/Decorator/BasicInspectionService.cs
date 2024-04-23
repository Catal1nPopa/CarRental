using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Decorator
{
    public class BasicInspectionService : IVehicleInspectionService
    {
        public string Inspect()
        {
            return $"Verificare de baza a vehiculului: Aspectul interior, Aspectul exterior, Analizare suspensie";
        }
    }
}
