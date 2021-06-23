using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("dora");
                    break;
                case 10:
                case 11:
                    Console.WriteLine("hay");
                    break;
                default:
                    Console.WriteLine("off");
                    break;
            }
        }
    }
}
