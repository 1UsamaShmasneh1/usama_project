using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_class_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8
            Computer lenovo = new Computer()
            {
                price = 6000,
                screenSize = 16
            };
            lenovo.TellMeThePrice();
            lenovo.TellMeTheScreenSize();
            lenovo.TurnOn();
            lenovo.AddProcessor();
            Console.WriteLine(lenovo.ToString());

            Computer acer = new Computer()
            {
                price = 12000,
                screenSize = 18
            };
            acer.TellMeThePrice();
            acer.TellMeTheScreenSize();
            acer.TurnOn();
            acer.TurnOff();
            acer.AddProcessor();
            acer.AddProcessor();
            acer.AddProcessor();
            Console.WriteLine(acer.ToString());

            Computer dell = new Computer()
            {
                price = 12000,
                screenSize = 18
            };
            dell.TellMeThePrice();
            dell.TellMeTheScreenSize();
            dell.TurnOn();
            dell.TurnOff();
            dell.AddProcessor();
            dell.AddProcessor();
            Console.WriteLine(dell.ToString());
            #endregion

            #region 9
            Table table1 = new Table();
            table1._tableLegs = 4;
            table1._color = "brown";
            table1._woodTybe = "alon";

            Table table2 = new Table(4, "brown", "alon");

            Table table3 = new Table()
            {
                _tableLegs = 4,
                _color = "brown",
                _woodTybe = "alon"
            };

            Table table4 = table2;
            table1._color = "red";
            table2._color = "black";
            table3._color = "yellow";
            table4._woodTybe = "sand";
            #endregion

            #region 10
            Rectangle x = new Rectangle(4, 7);
            Console.WriteLine(x.area);
            Console.WriteLine(x.scope);
            #endregion

            //-----------------------------------

            #region 7
            Car car1 = new Car("mazda");
            string brand = car1.GetBrand();
            #endregion

            #region 9
            int size = Convert.ToInt32(Console.ReadLine());
            Person[] persons = new Person[size];
            string[] personNames = new string[size];
            int[] personAges = new int[size];
            string name;
            int age;
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine("enter name");
                name = Console.ReadLine();
                Console.WriteLine("enter age");
                age = Convert.ToInt32(Console.ReadLine());
                persons[i] = new Person(name, age);
                personNames[i] = persons[i]._name;
                personAges[i] = persons[i]._age;
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Name: {persons[i]._name}. Age: {persons[i]}");
            }
            #endregion

            #region 10
            Game game1 = new Game("assassin's creed", "adventure", 450);
            Game game2 = new Game(game1._gameName, game1._gameTybe, game1._price);
            Game game3 = new Game(game1);
            #endregion
        }
    }
    #region 8
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors = 0;
        public float screenSize;
        public bool isTurnOn;

        public void TellMeThePrice()
        {
            Console.WriteLine(price);
        }

        public void TellMeTheScreenSize()
        {
            Console.WriteLine(screenSize);
        }

        public void TurnOn()
        {
            isTurnOn = true;
        }

        public void TurnOff()
        {
            isTurnOn = false;
        }

        public void AddProcessor()
        {
            numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"price: {price}, numberOfProcessors: {numberOfProcessors}, screenSize: {screenSize}, isTurnOn: {isTurnOn}".ToString();
        }
    }
    #endregion

    #region 9
    class Table
    {
        public int _tableLegs;
        public string _color;
        public string _woodTybe;
        public Table()
        {

        }

        public Table(int tableLegs, string color, string woodTybe)
        {
            _tableLegs = tableLegs;
            _color = color;
            _woodTybe = woodTybe;
        }
    }
    #endregion

    #region 10
    class Rectangle
    {
        public double scope;
        public double area;

        public Rectangle(int h, int w)
        {
            area = GetArea(h, w);
            scope = GetScope(h, w);
        }

        public double GetArea(int h, int w)
        {
            return h * w;
        }

        public double GetScope(int h, int w)
        {
            return 2 * (h + w);
        }
    }
    #endregion

    //--------------------------

    #region 7
    class Car
    {
        public string _brand;

        public Car(string brand)
        {
            _brand = brand;
        }

        public string GetBrand()
        {
            return _brand;
        }
    }
    #endregion

    #region 8
    class ConsolePlus
    {
        public string _str;
        public int _num1;
        public int _num2;

        public ConsolePlus()
        {
            Console.WriteLine("default");
        }

        public ConsolePlus(string str) : this(str, 0, 0)
        {
            Console.WriteLine(str);
        }

        public ConsolePlus(int num1, int num2) : this("", num1, num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public ConsolePlus(string str, int num1, int num2)
        {
            _str = str;
            _num1 = num1;
            _num2 = num2;
        }
    }
    #endregion

    #region 9
    class Person
    {
        public string _name;
        public int _age;
        public Person(string name)
        {
            _name = name;
        }
        public Person(string name, int age) : this(name)
        {
            _age = age;
        }
    }
    #endregion

    #region 10
    class Game
    {
        public string _gameName;
        public string _gameTybe;
        public int _price;
        public Game(string gameName, string gameTybe, int price)
        {
            _gameName = gameName;
            _gameTybe = gameTybe;
            _price = price;
        }
        public Game(Game game)
        {
            _gameName = game._gameName;
            _gameTybe = game._gameTybe;
            _price = game._price;
        }
    }
    #endregion
}
