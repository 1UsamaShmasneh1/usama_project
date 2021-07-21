using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_HomeWork
{
    class ref_out_HomeWork
    {
        static void Main(string[] args)
        {
            #region 2
            int a1 = 4;
            int b1 = 3;
            PlusMulti(ref a1, ref b1);
            Console.WriteLine($"{a1}, {b1}");
            #endregion

            #region 3
            int a2;
            int b2;
            GetValue(out a2, out b2);
            Console.WriteLine($"{a2}, {b2}");
            #endregion

            #region 4
            string errorMessage;
            bool isTrue = ValidateValues("usama", "shmasneh", "0525455876", "301548756", 30, out errorMessage);
            Console.WriteLine(isTrue);
            #endregion
        }
        #region 2
        public static void PlusMulti(ref int a, ref int b)
        {
            a++;
            b *= 2;
        }
        #endregion

        #region 3
        public static void GetValue(out int a, out int b)
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        #endregion

        #region 4
        public static bool ValidateValues(string firstName, string lastName, string teleNum, string id, int age, out string errorMessage)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                errorMessage = "enter valid firstName";
                return false;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                errorMessage = "enter valid lastName";
                return false;
            }
            if (Convert.ToInt32(teleNum[0]) == 0 && teleNum.Length >= 9)
            {
                errorMessage = "enter valid teleNum";
                return false;
            }
            if (id.Length == 9)
            {
                errorMessage = "enter valid id";
                return false;
            }
            if (age >= 1 && age <= 100)
            {
                errorMessage = "enter valid age";
                return false;
            }
            errorMessage = "pass";
            return true;
        }
        #endregion
    }
}
