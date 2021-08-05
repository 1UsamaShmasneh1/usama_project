using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class RepairMismatchException: ApplicationException
    {
        public RepairMismatchException()
        {

        }
        public RepairMismatchException(string str): base(str)
        {

        }
    }
}
