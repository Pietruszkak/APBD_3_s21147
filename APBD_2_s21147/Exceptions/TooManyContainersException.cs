using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Exceptions
{
    internal class TooManyContainersException : System.Exception
    {
        public TooManyContainersException()
        {
        }

        public TooManyContainersException(string message)
            : base(message)
        {
        }

        public TooManyContainersException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
