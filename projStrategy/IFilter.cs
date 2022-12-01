using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStrategy
{
    public interface IFilter
    {
        void Apply(string file);
    }
}
