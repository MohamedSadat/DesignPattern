using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class PermissionValidator : JournalHandler
    {
        public PermissionValidator(JournalHandler next) : base(next)
        {

        }
        
     
        public override bool DoHandle(Journal request)
        {
            Console.WriteLine("Permisiion valid");
            return false;
        }
    }
}
