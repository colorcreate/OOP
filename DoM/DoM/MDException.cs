using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class MDException: Exception
    {
        public MDException()
        {

        }

        public MDException (string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : MDException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
