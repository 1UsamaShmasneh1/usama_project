using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_loops
{
    class Program
    {
        static bool Is_primary(int n)
        {
            int m = 2;
            while (n % m != 0 && m < n)
            {
                m++;
            }
            if (n == m)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // f12 open opjects
            #region while
            int x = 5;
            while (x < 10)
            {
                Console.WriteLine(x * 3);
                x++;
            }
            #endregion

            #region while2
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            while (num < 20)
            {
                if (num > 14 && num % 2 == 0)
                {
                    int y1 = num / 2;
                    while (y1 > 0)
                    {
                        y1 -= 1;
                    }
                }
                counter++;
                num++;         
            }
            Console.WriteLine(counter);
            Console.ReadLine();
            #endregion

            #region switch
            int last_option = 0;
            while (true)
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case -1:
                        switch (last_option)
                        {
                            case -1:
                                Console.WriteLine("the light already broken");
                                break;
                            default:
                                Console.WriteLine("the light now broken");
                                last_option = option;
                                break;
                        }
                        last_option = option;
                        break;
                    case 0:
                        switch (last_option)
                        {
                            case -1:
                                Console.WriteLine("no way, the light already broken");
                                break;
                            default:
                                Console.WriteLine("status, the light is off");
                                last_option = option;
                                break;
                        }
                        last_option = option;
                        break;                     
                    case 1:
                        switch (last_option)
                        {
                            case 1:
                                Console.WriteLine("no way, the light now broken");
                                break;
                            default:
                                Console.WriteLine("status, the light is on");
                                last_option = option;
                                break;
                        }
                        last_option = option;
                        break;                        
                    default:
                        switch (last_option)
                        {
                            case 1:
                                Console.WriteLine("the light now fixed");
                                break;
                            default:
                                Console.WriteLine("ther no need, the light is useful");
                                last_option = 0;
                                break;
                        }
                        break;                        
                }
                if (option == 10)
                {
                    break;
                }
            }
            #endregion

            #region 3
            // 3
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num1 >= 0)
            {
                sum += num1;
            }
            Console.WriteLine(sum);
            #endregion//-----------------------------------------------------------------------------------------------------------------

            #region 4
            // 4
            int m = 2;
            int a = int.Parse(Console.ReadLine());
            while (a % m != 0 && m < a)
            {
                m++;
            }
            if (a == m)
            {
                Console.WriteLine("primary");
            }
            else
            {
                Console.WriteLine("not primary");
            }
            #endregion

            #region 5
            // 5
            int secret = int.Parse(Console.ReadLine());
            int guess = int.Parse(Console.ReadLine());
            if (guess < secret)
            {
                Console.WriteLine("small too");
            }
            else if (guess > secret)
            {
                Console.WriteLine("big too");
            }
            else if (guess == secret)
            {
                Console.WriteLine("bingo");
            }
            #endregion

             #region 6
            // 6
            int num2 = int.Parse(Console.ReadLine());
            int counter1 = 2;
            int result = 1;
            while (counter1 <= num2)
            {
                if (num2 == 0)
                {
                    result = 0;
                    break;
                }
                result *= counter1;
            }
            Console.WriteLine(result);
            #endregion

            #region time
            string time = DateTime.Now.ToString("HH-mm");
            #endregion
            #region for
            int x1 = 0, y = 0;
            for(int i = 0; i<5; i++)
            {
                x1 += 3;
                Console.WriteLine(x1);
                y = x1;
            }
            Console.WriteLine(y);
            #endregion

            #region test for + 1
            Console.WriteLine("enter number begger than 3");
            int num3 = int.Parse(Console.ReadLine());
            for(int i = 0; i <= num3 * 2; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if (i > 10)
                {
                    break;
                }
                else if(i == num3)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("end");
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 0, j = 10; i <= 10; i++, j--)
            {
                Console.WriteLine(i + j);
            }
            #endregion

            #region 2
            int counter3 = 0;
            while (true)
            {
                int num5 = Convert.ToInt32(Console.ReadLine());
                if (num5 == 23)
                {
                    Console.WriteLine("to exit enter y or Y");
                    string choose = Console.ReadLine();
                    switch (choose)
                    {
                        case "y":
                        case "Y":
                            Console.WriteLine(counter3);
                            break;
                        default:
                            Console.WriteLine("the loop is continue");
                            break;
                    }
                }
                counter3++;
            }
            #endregion
            //----
            #region 1
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region 2
            int sum1 = 0;
            for(int i = 0; i < 5; i++)
            {
                sum1 += i;
            }
            Console.WriteLine(sum / 5);
            #endregion

            #region 3
            for(int i = 0; i <= 7; i++)
            {
                Console.WriteLine(i);
                if(i == 7)
                    for (int o = 0; o <= 8; o++)
                    {
                        Console.WriteLine(o);
                        if (o == 8)
                            for (int p = 0; p <= 9; p++)
                            {
                                Console.WriteLine(p);                                
                            }

                    }
            }
            #endregion

            #region 4
            do
            {
                int num6 = Convert.ToInt32(Console.ReadLine());
                int num7 = Convert.ToInt32(Console.ReadLine());
                if(num6 == 0 || num7 == 0)
                {
                    continue;
                }
                else if(num6 < 0 || num7 < 0)
                {
                    break;
                }
                Console.WriteLine(num6 + num7);
                Console.WriteLine(num6 * num7);
            }
            while (true);
            #endregion
            //----
            #region 5
            for(int b = 1; b <= 10; b++)
            {
                for(int c = 1; c <= 10; c++)
                {
                    Console.Write(b * c + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            #region 1
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (Is_primary(n))
                {
                    Console.WriteLine("primary");
                    break;
                }
                else
                {
                    Console.WriteLine("not primary");
                }
            }
            #endregion

            #region 2
            Console.WriteLine("enter number of students");
            int num_st = Convert.ToInt32(Console.ReadLine());
            int[] class_s = { 100, 30, 10 };
            int rest_st = num_st;
            foreach (int x2 in class_s)
            {
                if (rest_st / x2 >= 1)
                    Console.Write("{0} class for {1} students", Convert.ToInt32(rest_st / x2), x2);
                rest_st %= x2;
                if (rest_st == 0)
                {
                    break;
                }
                else if (rest_st < 10)
                {
                    Console.Write(" {0} back to home.", rest_st);
                }
                else
                {
                    Console.Write(" and ");
                }
            }
            #endregion

            #region 3
            int num8 = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[num8];
            for (int z = 0; z < num8; z++)
            {
                nums[z] = z + 1;
            }
            foreach (int num_nums in nums)
            {
                foreach (int num1_nums in nums)
                {
                    Console.Write("{0} ", num1_nums);
                    if (num1_nums == num_nums)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
            for (int f = num8 - 1; f > 0; f--)
            {
                foreach (int num1_nums in nums)
                {
                    Console.Write("{0} ", num1_nums);
                    if (num1_nums == f)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region 4
            int num9 = Convert.ToInt32(Console.ReadLine());
            for (int u = 1; u <= num9; u++)
            {
                for (int i1 = u; i1 <= num9; i1++)
                {
                    Console.Write("  ");
                }
                for (int i2 = 1; i2 <= 2 * u - 1; i2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
