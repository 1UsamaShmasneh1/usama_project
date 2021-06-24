using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_array_____
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array[,] build
            int[,] myarr = new int[4,8];
            myarr[2, 3] = 5;
            for(int i = 0; i < myarr.GetLength(0); i++)
            {
                for(int j = 0; j < myarr.GetLength(1); j++)
                {
                    myarr[i, j] = 1;
                }
            }
            #endregion

            #region multiblcatin board
            int[,] culc = new int[10, 10] 
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {2, 4, 6, 8, 10, 12, 14, 16, 18, 20},
                {3, 6, 9, 12, 15, 18, 21, 24, 27, 30},
                {4, 8, 12, 16, 20, 24, 28, 32, 36, 40},
                {5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
                {6, 12, 18, 24, 30, 36, 42, 48, 54, 60},
                {7, 14, 21, 28, 35, 42, 49, 56, 63, 70},
                {8, 16, 24, 32, 40, 48, 56, 64, 72, 80},
                {9, 18, 27, 36, 45, 54, 63, 72, 81, 90},
                {10, 20, 30, 40, 50, 60, 70, 80, 90, 100}
            };
            for (int i = 0; i < culc.GetLength(0); i++)
            {
                for (int j = 0; j < culc.GetLength(1); j++)
                {
                    Console.Write($"{culc[i,j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            #endregion

            #region HW2
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num;
            int counter = 0;
            int counter2 = 0;
            for(int i = 0; i < 10; i++)
            {
                if(counter2 > 30)
                {
                    Console.WriteLine("game over, too many tries");
                    break;
                }
                while (true)
                {
                    Console.WriteLine("enter number");
                    num = Convert.ToInt32(Console.ReadLine());
                    counter += 1;
                    counter2 += 1;
                    if (Array.IndexOf(nums, num) == i)
                    {
                        Console.WriteLine($"you found the {i + 1} after {num} tries");
                        counter = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("wrong, try again");
                    }
                }
            }
            Console.WriteLine($"your all tries is {counter2} tries");
            #endregion

            #region HW3

            #endregion
        }
    }
}
