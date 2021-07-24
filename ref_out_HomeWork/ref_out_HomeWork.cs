using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_HomeWork
{
    class Ref_out_HomeWork
    {
        static void Main(string[] args)
        {
            #region ref, out
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
            #endregion

            #region params, in, optional
            #region 3
            int result = Default(a: 1, b: 10);
            #endregion

            #region 5
            Palaphone p1 = new Palaphone(6);
            Palaphone p2 = new Palaphone(model: "galaxy");
            Palaphone p3 = new Palaphone(battery: "very good");
            Palaphone p4 = new Palaphone(cameraQualety: "not good");
            #endregion
            #endregion
        }
        #region ref, out
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
        #endregion

        #region params, in, optional
        #region 1
        public static int sumNums(params int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] ^ (i + 1);
            }
            return sum;
        }
        #endregion

        #region 2
        public static int Default(int a, int b = 1, int c = 1)
        {
            return a * b * c;
        }
        #endregion

        #region 4
        public static int CaulcNum(in int num)
        {
            return num * 3;
        }
        #endregion
        #endregion
    }
}
