using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStrategy
{
    public class BAWFilter : IFilter
    {
        public void Apply(string file)
        {
            Console.WriteLine("Filter black");
        }
    }
}
