using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Domain.Entities
{
    public class CarInspection
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string CarNumber { get; set; }
        public Boolean Advanced { get; set; }
    }
}
