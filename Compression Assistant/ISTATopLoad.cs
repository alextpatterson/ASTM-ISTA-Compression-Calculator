using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression_Assistant
{
    class ISTATopLoad
    {
        double height;
        double length;
        double width;

        public ISTATopLoad(double h, double l, double w)
        {
            height = h;
            length = l;
            width = w;
        }

        public double GetHCompression() => ((108 - height) * length * width * 0.0035);

        public double GetWCompression() => ((108 - width) * length * height * 0.0035);

        public double GetLCompression() => ((108 - length) * width * height * 0.0035);

        
    }
}
