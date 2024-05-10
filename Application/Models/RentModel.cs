using CarRentail.Application.Requests;
using CarRentail.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Models
{
    public class RentModel
    {
        public int CustomerId { get; set; }
        public int rentalDays { get; set; }
        public int idCar { get; set; }
        public string vehicleTypes { get; set; }
    }
}
