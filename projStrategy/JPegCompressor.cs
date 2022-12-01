using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStrategy
{
    /// <summary>
    /// Strategy 1
    /// </summary>
    public class JPegCompressor : ICompressor
    {
        public void Compress(string file)
        {
            Console.WriteLine("Compress Jpeg");
        }
    }
}
