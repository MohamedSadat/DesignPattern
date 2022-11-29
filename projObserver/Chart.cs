using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projObserver
{
    public class Chart : IObserver<int>
    {
        //Pull style
        private DataSource ds;

        public Chart(DataSource ds)
        {
            this.ds = ds;
        }
        //End Pull

        public void Update(int value)
        {
          Console.WriteLine($"Chart updtated {value}");
        }

        public void UpdatePull()
        {
            Console.WriteLine($"chart Pulled {ds.Value}");

        }
    }
}
