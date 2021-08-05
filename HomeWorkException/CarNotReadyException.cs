using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class CarNotReadyException: ApplicationException
    {
        public CarNotReadyException()
        {

        }
        public CarNotReadyException(string str): base(str)
        {

        }
    }
}
