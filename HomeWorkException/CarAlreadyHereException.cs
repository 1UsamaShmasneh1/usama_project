using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class CarAlreadyHereException: ApplicationException
    {
        public CarAlreadyHereException()
        {

        }
        public CarAlreadyHereException(string str): base(str)
        {

        }
    }
}
