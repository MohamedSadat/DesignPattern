using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public abstract  class JournalHandler
    {
        private JournalHandler next;

        protected JournalHandler(JournalHandler next)
        {
            this.next = next;
        }
        public void  handle(Journal request)
        {
           if( DoHandle(request))
            { return; }
         
            if(next!= null)
            { next.handle(request); }
                
            
        }
        public abstract bool DoHandle(Journal request);
    }
}
