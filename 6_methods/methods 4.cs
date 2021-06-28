using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_methods
{
    class Class1
    {
        #region 1
        public static void Alert(string str)
        {
            Console.WriteLine(str);
        }
        #endregion

        #region 2
        public static void Nums_array(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Num(nums[i]);
            }
        }

        public static void Num(int num)
        {
            Console.WriteLine(num * 2);
        }
        #endregion

        #region 3
        public static int Culc(int num1, int num2, string sympol, int num3)
        {
            int new_num = 0;
            switch (sympol)
            {
                case "+":
                    new_num = (num1 + num2) * num3;
                    break;
                case "-":
                    new_num = (num1 - num2) * num3;
                    break;
                case "*":
                    new_num = (num1 * num2) * num3;
                    break;
                case "/":
                    new_num = (num1 / num2) * num3;
                    break;
            }
            return new_num;
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1
            for (int i = 0; i < 10; i++)
            {
                Alert(Console.ReadLine());
            }
            #endregion

            #region 2
            int[] nums = { 1, 4, 5, 6, 4, 8 };
            Nums_array(nums);
            #endregion

            #region 3
            Console.WriteLine(Culc(3, 5, "+", 2));
            #endregion
        }
    }
}
