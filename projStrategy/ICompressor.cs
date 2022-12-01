using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStrategy
{
    /// <summary>
    /// Strategy interface
    /// </summary>
    public interface ICompressor
    {
       // byte[] Compress(byte[] data);
        void Compress(string file);
    }
}
