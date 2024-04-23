using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Composite
{
    public class VehicleServiceManager
    {
        public static void ServiceVehicle()
        {
            // Creează servicii individuale
            var oilChange = new BasicServiceComposite("Schimb ulei", 29.99m);
            var tireRotation = new BasicServiceComposite("Rotire anvelope", 19.99m);
            var engineDiagnostic = new BasicServiceComposite("Diagnosticare motor", 49.99m);

            // Creează un pachet de servicii pentru revizie tehnică
            var technicalRevisionPackage = new ServicePackage("Revizie Tehnică");
            technicalRevisionPackage.AddService(oilChange);
            technicalRevisionPackage.AddService(tireRotation);
            technicalRevisionPackage.AddService(engineDiagnostic);

            // Efectuează serviciul
            technicalRevisionPackage.PerformService();
        }
    }
}
