using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class Journal
    {
        public DateTime JDate { get; set; } = DateTime.Now;
        public double Amount { get; set; } = 0;
        public Journal() { }

    }
}
