using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compression_Assistant
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Can't process a negative number. ")
        {
            
        }

        public NegativeNumberException(string message):base(message)
        {

        }
    }
}
