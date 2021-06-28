using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_methods
{
    class Program
    {
        public static int Age()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        static void Main(string[] args)
        {
            Age();
        }
    }
}
