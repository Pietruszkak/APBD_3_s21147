using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2_s21147.Exceptions
{
    public class OverfillException : System.Exception
    {
        public OverfillException()
        {
        }

        public OverfillException(string message)
            : base(message)
        {
        }

        public OverfillException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
