using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentail.Domain.Interface;

namespace CarRentail.Application.Observer
{
    public class VehicleSubject
    {
        private List<IVehicleObserver> _observers = new List<IVehicleObserver>();

        public void Attach(IVehicleObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
