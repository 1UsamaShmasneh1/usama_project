using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class CarNullException: ApplicationException
    {
        public CarNullException()
        {

        }
        public CarNullException(string str): base(str)
        {

        }
    }
}
