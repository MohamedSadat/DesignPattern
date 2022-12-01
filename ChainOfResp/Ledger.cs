using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class Ledger
    {
        private JournalHandler handler;

        public Ledger(JournalHandler handler)
        {
            this.handler = handler;
        }
        public void Handle(Journal request)
        {
            handler.handle(request);
        }
    }
}
