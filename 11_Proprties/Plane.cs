using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Proprties
{
    class Plane: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("plane fly");
        }

        public double GetAltitude()
        {
            return 1056.4;
        }
    }
}
