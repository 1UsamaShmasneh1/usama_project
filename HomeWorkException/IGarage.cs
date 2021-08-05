using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkException
{
    interface IGarage
    {
        void AddCar(Car car);
        void GetOutCar(Car car);
        void FixCar(Car car);
    }
}
