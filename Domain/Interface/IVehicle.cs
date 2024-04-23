using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Interface
{
    public interface IVehicle
    {
        int Id { get; set; }
        string Brand { get; set; }
        public string CarNumber { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        int Distance { get; set; }
        string Photo { get; set; }
        int Price { get; set; }
        int EnginePower { get; set; }
        bool State { get; set; }
    }
}
