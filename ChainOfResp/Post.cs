using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class Post : JournalHandler
    {
        public Post(JournalHandler next) : base(next)
        {
        }
    
        public override bool DoHandle(Journal request)
        {
            Console.WriteLine($"Journal posted amount{request.Amount}");
            return false;//End the chain

        }
    }
}
