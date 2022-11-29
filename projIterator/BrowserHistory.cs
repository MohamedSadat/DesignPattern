using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projIterator
{
    public class BrowserHistory
    {
        public void Push(string url)
        {
            Urls.Add(url);
        }
        public string Pop()
        {
            var last=Urls.Last();
            Urls.Remove(last);
            return last;
        }
        public List<string> Urls {private get; set; }=new List<string>();
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : IIterator<string>
        {
            private readonly BrowserHistory history;
            public int Index { get; set; }
            public ListIterator(BrowserHistory history)
            {
                this.history = history;
            }
            public string Current()
            {
            return history.Urls[Index];
            }

            public bool HasNext()
            {

                return (Index < history.Urls.Count);
            }

            public void Next()
            {
                Index++;
            }
        }
    }
}
