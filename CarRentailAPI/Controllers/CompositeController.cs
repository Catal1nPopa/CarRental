using CarRentail.Application.Composite;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompositeController : ControllerBase
    {
        [HttpPost("BasicService")]
        public ActionResult PerformBasicService([FromBody] BasicServiceInfo serviceInfo)
        {
            // Creează o serviciu bază folosind informațiile primite
            var basicService = new BasicServiceComposite(serviceInfo.Name, serviceInfo.Price);

            // Efectuează serviciul
            basicService.PerformService();

            return Ok($"Serviciul {serviceInfo.Name} a fost efectuat cu succes.");
        }

        [HttpPost("ServicePackage")]
        public ActionResult PerformServicePackage([FromBody] ServicePackageInfo packageInfo)
        {
            // Creează un pachet de servicii
            var servicePackage = new ServicePackage(packageInfo.Name);

            // Adaugă serviciile la pachet
            foreach (var service in packageInfo.Services)
            {
                servicePackage.AddService(new BasicServiceComposite(service.Name, service.Price));
            }

            // Efectuează pachetul de servicii
            servicePackage.PerformService();

            return Ok($"Pachetul de servicii {packageInfo.Name} a fost efectuat cu succes.");
        }
        public class BasicServiceInfo
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class ServicePackageInfo
        {
            public string Name { get; set; }
            public List<BasicServiceInfo> Services { get; set; }
        }
    }
}
