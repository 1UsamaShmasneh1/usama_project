using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class NoMoreRangInGarage: ApplicationException
    {
        public NoMoreRangInGarage()
        {

        }
        public NoMoreRangInGarage(string str): base(str)
        {

        }
    }
}
