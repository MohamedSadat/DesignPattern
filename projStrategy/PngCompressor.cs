using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStrategy
{
    /// <summary>
    /// Strategy 2
    /// </summary>
    internal class PngCompressor : ICompressor
    {
        public void Compress(string file)
        {
            Console.WriteLine("Compress PNG");
        }
    }
}
