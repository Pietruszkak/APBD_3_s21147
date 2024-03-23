using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Exceptions
{
    internal class WrongTemperatureException : System.Exception
    {
        public WrongTemperatureException()
        {
        }

        public WrongTemperatureException(string message)
            : base(message)
        {
        }

        public WrongTemperatureException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
