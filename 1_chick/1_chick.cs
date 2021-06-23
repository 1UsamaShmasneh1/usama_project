using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_chick
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of students");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] signs = new int[num];
            int sum = 0;
            int avg;
            for(int i = 0; i < signs.Length; i++)
            {
                Console.WriteLine("enter sign");
                signs[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < signs.Length; i++)
            {
                sum += signs[i];
                Console.WriteLine(sum);
                if (i == signs.Length - 1)
                    Console.WriteLine(sum / signs.Length);
            }

        }
    }
}
