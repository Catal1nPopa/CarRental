using CarRentail.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Decorator
{
    public class AdvancedInspectionServiceDecorator : VehicleInspectionDecorator
    {
        public AdvancedInspectionServiceDecorator(IVehicleInspectionService decoratedInspectionService)
            : base(decoratedInspectionService)
        {
        }

        public override string Inspect()
        {
            string basicInspectionResults = base.Inspect();
            string advancedInspectionResults = PerformAdvancedDiagnostics();
            return $"{basicInspectionResults}\n{advancedInspectionResults}";
        }

        private string PerformAdvancedDiagnostics()
        {
            // Adăugare verificări avansate aici
            return "Se efectuează verificări avansate ale vehiculului: sistemul de frânare, motorul, transmisia, kilometraj, cutia de viteze";
        }
    }
}
