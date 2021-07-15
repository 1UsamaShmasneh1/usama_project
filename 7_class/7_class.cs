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
            Car myCar = new Car(true)
            {
                _year = 2021,
                _brand = "Mazdaa",
                _isActive = true
            };
            myCar.Drive();
            myCar.GetKm();

            Car myCar2 = new Car("Mazda", true);
            myCar2._year = 2020;
            myCar2.Drive();
            Console.WriteLine($"{myCar2._brand}, {myCar2._isActive}");
            Console.ReadLine();
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
        public Car() : this(0, "", false, false, 0)
        {
        }

        public Car(bool drive) : this(0, "", false, drive, 0)
        {
        }

        public Car(string brandToCar, bool active) : this(0, brandToCar, active, false, 0)
        {
        }

        public Car(int year, string brand, bool isActive, bool isDrive, int km)
        {
            _year = year;
            _isDrive = isDrive;
            _km = km;
            _brand = brand;
            _isActive = isActive;
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
