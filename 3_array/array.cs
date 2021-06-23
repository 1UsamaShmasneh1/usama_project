using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array build
            int x = 5;
            int[] myArray = new int[5];

            int[] myArray1 = { 0, 1, 2 };

            int[] myArray2 = new int[3] { 0, 1, 2 };

            char[] myChars;
            int size = Convert.ToInt32(Console.ReadLine());
            myChars = new char[size];
            #endregion

            #region 1
            int[] nums = new int[10] { 1, 5, 8, 123, 4564, 789, 4, 12, 412, 44};
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    Console.WriteLine(nums[i]);
            }
            #endregion

            #region 2 
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];
            for(int i = 0; i < 10; i++)
            {
                nums1[i] = Convert.ToInt32(Console.ReadLine());
                nums2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                if (nums1[i] >= nums2[i])
                {
                    Console.WriteLine(nums1[i]);
                }
                else
                {
                    Console.WriteLine(nums2[i]);

                }
            }
            #endregion

            #region 6
            Console.WriteLine("enter number of students");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] signs = new int[num];
            int sum = 0;
            int avg;
            for (int i = 0; i < signs.Length; i++)
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
            #endregion
        }
    }
}
