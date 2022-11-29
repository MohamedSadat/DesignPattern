using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projObserver
{
    /// <summary>
    /// Observable or concrete Subject
    /// </summary>
    public class DataSource : Subject<int>
    {
        public DataSource() { }
        private int value;

        public int Value 
        { 
            get => value;

            set { 
                this.value = value;
            NotifyObservers(value);
                //Push style
            }

        
        }
    }
}
