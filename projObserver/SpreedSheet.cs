using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projObserver
{
    /// <summary>
    /// Observer
    /// </summary>
    public class SpreedSheet : IObserver<int>
    {
        //Pull style
        private DataSource ds;

        public SpreedSheet(DataSource ds)
        {
            this.ds = ds;
        }

        public void Update(int value)
        {
            Console.WriteLine($"Sheet updtated {value}");

        }

        public void UpdatePull()
        {
            Console.WriteLine($"Sheet Pulled {ds.Value}");

        }
    }
}
