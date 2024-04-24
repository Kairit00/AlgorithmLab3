using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab3
{
    internal class ListIndexOutOfBoundsException : Exception 
    {
        public ListIndexOutOfBoundsException() : base("List index out of bounds.") { } // default message


        public ListIndexOutOfBoundsException(string message, Exception innerException) : base(message, innerException) { } // inner exception
    }
}
