using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Proprties
{
    class Crow : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Crow fly");
        }

        public double GetAltitude()
        {
            return 13.8;
        }
    }
}
