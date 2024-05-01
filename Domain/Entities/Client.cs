using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDateTime { get; set; }
        public int rentalCars { get; set; }
    }
}
