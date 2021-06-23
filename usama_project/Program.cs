using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usama_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;

            long l = 1000000000000000;
            l = x;

            x = (int)l;

            string ss = "5";
            string ss1 = "usama";

            int t = int.Parse(ss);
            int t1 = int.Parse(ss1);

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
