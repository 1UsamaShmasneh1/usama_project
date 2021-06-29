using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Methods_Home_Work
{
    class Program
    {
        #region 8
        public static string Num_word(int num)
        {
            string word = "";
            switch (num)
            {
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "tow";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
                case 10:
                    word = "ten";
                    break;
            }
            return word;
        }
        #endregion

        #region 9
        private static bool PrintNumber(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            if (num > 0 && num <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 10
        public static void PrintNum(int num)
        {
            Console.WriteLine(num);
            if (num < 10)
                PrintNum(++num);
        }
        #endregion

        #region 11
        private static int IsPrimary(int num)
        {
            int m = 2;
            while (num % m != 0 && m<num)
                {
                    m++;
                }
            if (num == m)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region 12
        private static void IsPrimary2(int[] num)
        {
            int m = 2;
            for(int i = 0; i < num.Length; i++)
            {
                while (i % m != 0 && m < i)
                {
                    m++;
                }
                if (i == m)
                {
                    Console.WriteLine($"the number {num[i]} is primary");
                }
                else
                {
                    Console.WriteLine($"the number {num[i]} is not primary");
                }
            }
        }
        #endregion

        #region 13
        private static int IsBigger(int[] nums1, int[] nums2)
        {
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < nums1.Length; i++)
            {
                sum1 += nums1[i];
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                sum2 += nums2[i];
            }
            if(sum1 > sum2)
            {
                return 1;
            }
            else if(sum1 == sum2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region 14
        private static int[,] CreatRandomMatrix()
        {
            int[,] nums = new int[10, 10];
            Random num = new Random();
            for(int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(0); j++)
                {
                    nums[i, j] = num.Next(101);
                }
            }
            return nums;
        }

        private static void IsExist(int[,] nums)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(0); j++)
                {
                    if(nums[i, j] == num)
                    {
                        Console.WriteLine("exist");
                        return;
                    }
                }
            }
            Console.WriteLine("exist");
        }
        #endregion

        #region 15
        private static void SortArray(int[] nums)
        {
            Array.Sort(nums);
        }
        private static void PrintArray(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region 8
            Console.WriteLine("enter number");
            Console.WriteLine(Num_word(Convert.ToInt32(Console.ReadLine())));
            #endregion

            #region 9
            PrintNumber(Convert.ToInt32(Console.ReadLine()));
            #endregion

            #region 10
            PrintNum(1);
            #endregion

            #region 11
            Console.WriteLine(IsPrimary(Convert.ToInt32(Console.ReadLine())));
            #endregion

            #region 12
            int[] nums = { 5, 4, 75, 24, 77, 89, 45 };
            IsPrimary2(nums);
            #endregion

            #region 13
            int[] nums1 = { 67, 43, 5, 78, };
            int[] nums2 = { 6, 45, 8, 2, 4, 9, 32 };
            int retur = IsBigger(nums1, nums2);
            #endregion

            #region 14
            int[,] nums3 = CreatRandomMatrix();
            for(int i = 1; i <= 10; i++)
            {
                IsExist(nums3);
            }
            #endregion

            #region 14
            int[] nums4 = { -5, 10, 15, 2, 5, 100 };
            SortArray(nums4);
            PrintArray(nums4);
            #endregion
        }
    }
}
