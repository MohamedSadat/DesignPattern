using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projObserver
{
    public abstract class Subject<T>
    {
        private List<IObserver<T>> _observers = new List<IObserver<T>>();
        public void AddObserver(IObserver<T> obsrver)
        {
            _observers.Add(obsrver);
        }
        public void RemoveObserver(IObserver<T> obsrver) { 

        _observers.Remove(obsrver);
        }
        public void NotifyObservers(T value)
        {
            foreach(var o in _observers)
            {
                o.Update(value);
                o.UpdatePull();

            }
        }
    }
}
