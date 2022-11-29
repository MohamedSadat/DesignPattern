using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projObserver
{
    public interface IObserver<T>
    {
        void Update(T value);
        void UpdatePull();

    }
}
