using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    class WeDoNotFixTotalLostException: ApplicationException
    {
        public WeDoNotFixTotalLostException()
        {

        }
        public WeDoNotFixTotalLostException(string str): base(str)
        {

        }
    }
}
