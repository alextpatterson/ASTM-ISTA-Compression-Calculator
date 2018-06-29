using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression_Assistant
{
    class ApplyRelease
    {
        double w;
        double s;
        double f;

        public ApplyRelease(double weight, int numBoxes, int Ffactor)
        {
            w = weight;
            s = numBoxes;
            f = Ffactor;
        }

        public double GetApplyRelease()
        {
            return (w * (s - 1) * f) * 1.4;
        }
    }
}
