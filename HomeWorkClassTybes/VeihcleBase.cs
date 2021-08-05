using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassTybes
{
    abstract class VeihcleBase
    {
        int numberOfWheels;
        string model;
        public abstract int GetMaxNumOfPassangers();
        public abstract int GetMaxSpeed();
        public override string ToString()
        {
            return "";
        }
    }
}
