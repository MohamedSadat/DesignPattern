using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    internal class PeriodValidator : JournalHandler
    {
        public PeriodValidator(JournalHandler next) : base(next)
        {
        }
       
        public override bool DoHandle(Journal request)
        {
            Console.WriteLine("Period valid");
            return false;
        }
    }
}
