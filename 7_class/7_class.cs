using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region class build
            Car myCar = new Car("Mazda")
            {
                _year = 2021,
                _brand = "Mazda",
                _isActive = true
            };
            myCar.Drive();
            myCar.GetKm();

            Car myCar2 = new Car("Mazda");
            myCar2._year = 2020;
            myCar2._brand = "Chevrolet";
            myCar2._isActive = false;
            myCar2.Drive();
            bool isRefEqu = Car.ReferenceEquals(myCar, myCar2);
            bool isEqu =  myCar.Equals(myCar2);
            #endregion
        }
    }
    #region class build
    class Car
    {
        public int _year;
        public string _brand;
        public bool _isActive;
        public bool _isDrive;
        public int _km;
        public Car()
        {

        }

        public Car(string brandToCar)
        {
            _brand = brandToCar;
            _isActive = true;
        }

        public Car(int year, string brand, bool isActive, bool isDrive, int km) : this(brand)
        {
            _year = year;
            _isDrive = isDrive;
            _isActive = isActive;
            _km = km;
        }

        public void Drive()
        {
            if (_isActive)
            {
            _isDrive = true;
            _km = 120;
            }
            else
            {
                Console.WriteLine("you can't drive");
            }
        }

        public int GetKm()
        {
            if (_isDrive)
            {
                return _km;
            }
            else
            {
                return -1;
            }

        }
    }
    #endregion
}
