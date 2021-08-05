using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassTybes
{
    class Motorcycle : VeihcleBase
    {
        private int numberOfHandBrakes;
        public int NumberOfHandBrakes { get; set; }
        public override int GetMaxNumOfPassangers()
        {
            throw new NotImplementedException();
        }

        public override int GetMaxSpeed()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString() + numberOfHandBrakes;
        }
    }
}
