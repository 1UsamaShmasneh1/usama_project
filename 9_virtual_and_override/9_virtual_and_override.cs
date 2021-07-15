using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_virtual_and_override
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Anemal
    {
        public int legs;
        public virtual void Eat()
        {
            Console.WriteLine("yammi");
        }
    }
    class Dog: Anemal
    {
        public void Bark()
        {

        }
        public override void Eat()
        {
            Console.WriteLine("noooo");
        }
    }
    class Cat : Anemal
    {
        public new void Eat()
        {
            Console.WriteLine("noooo");
        }
    }
}
