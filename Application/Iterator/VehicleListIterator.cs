using CarRentail.Domain.Entities;
using CarRentail.Domain.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentail.Application.Iterator
{
    public class VehicleListIterator : IVehicleIterator
    {
        private List<Vehicle> _vehicles;
        private int _position = -1;
        public IEnumerator<Vehicle> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
