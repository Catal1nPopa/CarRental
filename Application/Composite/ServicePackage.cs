using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.Composite
{
    public class ServicePackage : IServiceComponent
    {
        private string _packageName;
        private List<IServiceComponent> _services = new List<IServiceComponent>();

        public ServicePackage(string packageName)
        {
            _packageName = packageName;
        }

        public void AddService(IServiceComponent serviceComponent)
        {
            _services.Add(serviceComponent);
        }

        public void PerformService()
        {
            Console.WriteLine($"Se începe pachetul de servicii: {_packageName}.");
            foreach (var service in _services)
            {
                service.PerformService();
            }
            Console.WriteLine($"Se finalizează pachetul de servicii: {_packageName}.");
        }
    }
}
