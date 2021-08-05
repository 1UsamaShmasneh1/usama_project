using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class WrongGarageException: ApplicationException
    {
        public WrongGarageException()
        {

        }
        public WrongGarageException(string str): base(str)
        {

        }
    }
}
