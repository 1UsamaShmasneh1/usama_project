using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class CarNotInGarageException: ApplicationException
    {
        public CarNotInGarageException()
        {

        }
        public CarNotInGarageException(string str): base(str)
        {

        }
    }
}
