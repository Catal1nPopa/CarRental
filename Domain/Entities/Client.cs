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
        public string PhoneNumber { get; set; }
        public int rentalCars { get; set; }

        public Client(){}
        public Client(int id, string name, DateTime registerDateTime, string phoneNumber, int rentalCars)
        {
            Id = id;
            Name = name;
            RegisterDateTime = registerDateTime;
            PhoneNumber = phoneNumber;
            this.rentalCars = rentalCars;
        }
    }
}
