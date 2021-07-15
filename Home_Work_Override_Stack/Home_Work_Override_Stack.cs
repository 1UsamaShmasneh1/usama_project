using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Override_Stack
{
    class Home_Work_Override_Stack
    {
        static void Main(string[] args)
        {
            #region 3
            Vehicle onlyBase = new Vehicle();
            onlyBase.AddWheel();
            onlyBase.OpenOrCloseRoof();
            Vehicle baseWithCar = new Car();
            baseWithCar.AddWheel();
            baseWithCar.OpenOrCloseRoof();
            Vehicle baseWithMotor = new Motorcycle();
            baseWithMotor.AddWheel();
            baseWithMotor.OpenOrCloseRoof();
            Car onlyCar = new Car();
            onlyCar.AddWheel();
            onlyCar.OpenOrCloseRoof();
            Motorcycle onlyMotor = new Motorcycle();
            onlyMotor.AddWheel();
            onlyMotor.OpenOrCloseRoof();
            Console.ReadLine();
            #endregion

            #region 4
            Person person1 = new Person()
            {
                personId = 305145745,
                firstName = "usama",
                lasttName = "shmasne"
            };
            Person2 person2 = new Person2()
            {
                personId = 305145740,
                firstName = "usama",
                lasttName = "shmasne"
            };
            Person person3 = new Person()
            {
                personId = 305145745,
                firstName = "usamaa",
                lasttName = "shmasne"
            };
            person1.isEqual(person2);
            person2.isEqual(person3);
            person1.isEqual(person3);

            #endregion
            //--------------------------------------


        }
    }
    #region 3
    class Vehicle
    {
        public int numWheels = 0;
        public string colore;
        public bool isOpenRoof = false;
        public virtual void AddWheel()
        {
            if(numWheels < 4)
            {
                numWheels++;
                Console.WriteLine($"wheels: {numWheels}");
            }
        }
        public void OpenOrCloseRoof()
        {
            switch (isOpenRoof)
            {
                case true:
                    isOpenRoof = false;
                    Console.WriteLine("the roof now is close");
                    break;
                case false:
                    isOpenRoof = true;
                    Console.WriteLine("the roof now is open");
                    break;
            }
        }
    }
    class Car: Vehicle
    {

    }
    class Motorcycle: Vehicle
    {
        public override void AddWheel()
        {
            if(numWheels < 2)
            {
                numWheels++;
                Console.WriteLine($"wheels: {numWheels}");
            }
        }
        public new void OpenOrCloseRoof()
        {
            isOpenRoof = true;
            Console.WriteLine("in motorcycle the roof always open");
        }
    }
    #endregion

    #region 4
     class Person
    {
        public int personId;
        public string firstName;
        public string lasttName;
        public virtual void isEqual(Person person)
        {
            if(person.personId == this.personId)
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }
        }
    }
    class Person2: Person
    {
        public override void isEqual(Person person)
        {
            if (person.firstName == this.firstName && person.lasttName == this.lasttName)
            {
                Console.WriteLine("equals");
            }
            else
            {
                Console.WriteLine("not equals");
            }
        }
    }
    #endregion
    //--------------------------------------

    #region 7
    class Clock
    {
        public int _hours;
        public int _Minutes;
        public int _seconds;
        public string _day;
        public int _temp;
        public Clock(int hours, int minutes, int seconds, string day, int temp)
        {
            _hours = hours;
            _Minutes = minutes;
            _seconds = seconds;
            _day = day;
            _temp = temp;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"{_hours}:{_Minutes}");
        }
        public void PrintDetails(int seconds)
        {
            Console.WriteLine($"{_hours}:{_Minutes}:{seconds}");
        }
        public void PrintDetails(int seconds, string day, int temp)
        {
            Console.WriteLine($"{_hours}:{_Minutes}:{seconds}   day: {day}   temp: {temp}");
        }
    }
    #endregion

    #region 8
    class Computer
    {
        public string[] _openFiles;
        public bool isOn;
        public Computer(string[] openFiles)
        {
            isOn = true;
            _openFiles = openFiles;
        }
        public void TurnOff()
        {
            _openFiles = null;
            isOn = false;
        }
        public void TurnOff(bool onOrOff)
        {
            if(_openFiles == null)
            {
                TurnOff();
            }
            else
            {
                Console.WriteLine("Are You Sure? y-n");
                string answer = Console.ReadLine();
                if(answer == "y")
                {
                    TurnOff();
                }
            }
        }
    }

    class SmartComp : Computer
    {
        public string[] _filesInCache;
        public SmartComp(string[] openFiles): base(openFiles)
        {

        }
        public new void TurnOff(bool onOrOff)
        {
            if (_openFiles.Count(null) == _openFiles.Length)
            {
                TurnOff();
            }
            else
            {
                _filesInCache = _openFiles;
                _openFiles = null;
                isOn = onOrOff;
            }
        }
    }
    #endregion
}
