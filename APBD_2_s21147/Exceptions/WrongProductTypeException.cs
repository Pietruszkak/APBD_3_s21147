using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Exceptions
{
    internal class WrongProductTypeException : System.Exception
    {
        public WrongProductTypeException()
        {
        }

        public WrongProductTypeException(string message)
            : base(message)
        {
        }

        public WrongProductTypeException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
