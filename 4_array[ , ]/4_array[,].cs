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

            #region HW2
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num;
            int counter = 0;
            for(int i = 0; i < 10; i++)
            {
                while (true)
                {
                    if (counter > 30)
                    {
                        Console.WriteLine("game over, too many tries");
                        break;
                    }
                    Console.WriteLine("enter number");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (Array.IndexOf(nums, num) == i)
                    {
                        Console.WriteLine($"you found the side {i + 1} after {counter} tries");
                        counter = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("wrong, try again");
                        counter++;
                    }
                }
            }
            #endregion

            #region HW3
            int[,] nums2 = {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
            };
            Console.WriteLine("enter number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    if(nums2[i, j] == num2)
                    {
                        Console.WriteLine($"the number funde in the row {i} and column {j}");
                        break;
                    }
                    else if (i == 4 && j == 4)
                    {
                        Console.WriteLine("the number not funde in the table");
                    }
                }
            }
            #endregion

            #region HW4
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
                    Console.Write($"{culc[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            #endregion

            #region HW5
            int[,] nums3 =
            {
                {0, 1, 0},
                {1, 0, 1},
                {0, 1, 1}
            };
            int row;
            int column;
            int counter3 = 0;
            while (true)
            {
                if (Array.IndexOf(nums3, 1) == -1)
                {
                    Console.WriteLine(counter3);
                    break;
                }
                row = Convert.ToInt32(Console.ReadLine());
                column = Convert.ToInt32(Console.ReadLine());
                if(nums3[row, column] == 1)
                {
                    Console.WriteLine("Boom");
                    counter3++;
                }
                else
                {
                    Console.WriteLine("Miss");
                    counter3++;
                }
            }
            #endregion

            #region HW6
            int[,,] nums4 = new int[2, 2, 2];
            for(int i = 0; i < nums4.GetLength(0); i++)
            {
                for (int j = 0; j < nums4.GetLength(1); j++)
                {
                    for (int k = 0; k < nums4.GetLength(2); k++)
                    {
                        Console.WriteLine("enter number");
                        nums4[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < nums4.GetLength(0); i++)
            {
                for (int j = 0; j < nums4.GetLength(1); j++)
                {
                    for (int k = 0; k < nums4.GetLength(2); k++)
                    {
                        Console.WriteLine(nums4[i, j, k]);
                    }
                }
            }
            #endregion

            #region HW7
            int[,] x = new int[6, 4];
            for(int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            #endregion

            #region HW8
            int[][] nums6 = new int[3][];
            nums6[0] = new int[2];
            nums6[1] = new int[2];
            nums6[2] = new int[2];
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < nums6[i].Length; j++)
                {
                    Console.WriteLine("enter number");
                    nums6[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < nums6[i].Length; j++)
                {
                    Console.WriteLine(nums6[i][j]);
                }
            }
            #endregion

            #region HW9
            Console.WriteLine("enter number of classs");
            int classs = Convert.ToInt32(Console.ReadLine());
            int[][] class2 = new int[classs][];
            int[] class_avg = new int[classs];
            int max_avg = 0;
            for(int i = 0; i < class2.Length; i++)
            {
                Console.WriteLine($"enter number of students in class {i + 1}");
                class2[i] = new int[Convert.ToInt32(Console.ReadLine())];
            }
            for (int i = 0; i < class2.Length; i++)
            {
                for (int j = 0; j < class2[i].Length; j++)
                {
                    Console.WriteLine($"enter grade of student {j + 1} who in class {i + 1}");
                    class2[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < nums6[i].Length; j++)
                {
                    class_avg[i] += class2[i][j];
                }
                class_avg[i] /= class2[i].Length;
                if (class_avg[i] > max_avg)
                    max_avg = class_avg[i];
            }
            Console.WriteLine($"the class {Array.IndexOf(class_avg, max_avg) + 1} has the bigger grade which is {max_avg}");
            #endregion
        }
    }
}
