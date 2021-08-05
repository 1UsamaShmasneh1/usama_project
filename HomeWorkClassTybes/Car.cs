using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClassTybes
{
    class Car : VeihcleBase
    {
        private int numberOfDoors;
        public int NumberOfDoors { get; set; }
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
            return base.ToString() + numberOfDoors;
        }
    }
}
