using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_methods_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            PrintInTowRows("d", "e");
            PrintInTowRows(3, 4);
            PrintInTowRows(true, false);
            #endregion
        }
        #region 1
        public static void PrintInTowRows(string str1, string str2)
        {
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

        public static void PrintInTowRows(int num1, int num2)
        {
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        public static void PrintInTowRows(bool bool1, bool bool2)
        {
            Console.WriteLine(bool1);
            Console.WriteLine(bool2);
        }
        #endregion
    }
    class Calculator
    {
        public int calc(int num1, int num2, string mark)
        {
            int newNum = 0;
            switch (mark)
            {
                case "+":
                    newNum = num1 + num2;
                    break;
                case "-":
                    newNum = num1 - num2;
                    break;
                case "*":
                    newNum = num1 * num2;
                    break;
                case "/":
                    newNum = (int)(num1 / num2);
                    break;
            }
            return newNum;
        }
        public double calc(double num1, double num2, string mark)
        {
            double newNum = 0;
            switch (mark)
            {
                case "+":
                    newNum = num1 + num2;
                    break;
                case "-":
                    newNum = num1 - num2;
                    break;
                case "*":
                    newNum = num1 * num2;
                    break;
                case "/":
                    newNum = num1 / num2;
                    break;
            }
            return newNum;
        }
        public string calc(string num1, string num2, string mark)
        {
            string newNum = "";
            switch (mark)
            {
                case "+":
                    newNum = Convert.ToString(Convert.ToInt32(num1) + Convert.ToInt32(num2));
                    break;
                case "-":
                    newNum = Convert.ToString(Convert.ToInt32(num1) - Convert.ToInt32(num2));
                    break;
                case "*":
                    newNum = Convert.ToString(Convert.ToInt32(num1) * Convert.ToInt32(num2));
                    break;
                case "/":
                    newNum = Convert.ToString((int)(Convert.ToInt32(num1) / Convert.ToInt32(num2)));
                    break;
            }
            return newNum;
        }
    }
}
