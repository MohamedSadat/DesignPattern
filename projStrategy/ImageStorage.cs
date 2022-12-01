using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projStrategy
{
    /// <summary>
    /// Contex
    /// </summary>
    public class ImageStorage
    {
        private readonly ICompressor compressor;
        private readonly IFilter filter;

        public ImageStorage(ICompressor compressor,IFilter filter) 
        {
            this.compressor = compressor;
            this.filter = filter;
        }
        public void Store(string filename)
        {
            compressor.Compress(filename);
            filter.Apply(filename);

        }
    }
}
