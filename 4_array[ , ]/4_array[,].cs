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

            #region 1
            int[,] culc = new int[10, 10] 
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {2, 4, 6, 8, 10, 12, 14, 16, 18, 20},
                {3, 6, 9, 12, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            };
            for (int i = 0; i <= culc.GetLength(0); i++)
            {
                for (int j = 0; j <= culc.GetLength(1); j++)
                {
                    Console.Write($"{culc[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion
        }
    }
}
